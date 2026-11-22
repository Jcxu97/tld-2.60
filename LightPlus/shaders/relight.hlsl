// LightPlus relight pass, runs on the lighting buffer right after Unity's deferred lights.
// Colors follow BSL v10.1.8 (lib/color/lightColor.glsl, ambientColor.glsl, lib/surface/ggx.glsl)
// with the settings from the user's BSL_v10.1.8.zip.txt.

cbuffer P : register(b0)
{
    row_major float4x4 invVP;
    row_major float4x4 shadowVP;
    float4 cam;      // xyz camera position, w time
    float4 light;    // xyz direction toward the sun or moon, w sun height
    float4 tune;
    float4 range;    // y shadow range
    float4 flags;    // x screen flip y, y shadow flip y, z shadow bias, w frame
    float4 misc;     // x evening (1) or morning (0)
    float4 pad1;
    float4 rt;       // filled by the plugin: target w h, viewport x y
    float4 vp;       // filled by the plugin: viewport w h
    float4 rl;       // x tint, y specular, z contrast, w debug
};

Texture2D lightTex : register(t0);
Texture2D<float> depthTex : register(t1);
Texture2D<float> shadowTex : register(t2);
Texture2D gb0 : register(t3);   // albedo, occlusion
Texture2D gb1 : register(t4);   // specular, smoothness
Texture2D gb2 : register(t5);   // world normal * 0.5 + 0.5
Texture2D maskTex : register(t6);   // the game's own screen-space sun shadow, 1 lit
SamplerState sLin : register(s0);
SamplerState sPt : register(s1);

static const float LIGHT_MI = 1.00, LIGHT_DI = 1.15, LIGHT_EI = 1.00, LIGHT_NI = 0.85;
static const float AMBIENT_MI = 0.35, AMBIENT_DI = 0.60, AMBIENT_EI = 0.35, AMBIENT_NI = 0.60;

float Lum(float3 c) { return dot(c, float3(0.299, 0.587, 0.114)); }
float3 Lin(float3 c) { return pow(max(c, 0), 2.2); }

float3 ToWorld(float2 ndc, float z)
{
    float4 w = mul(invVP, float4(ndc, z, 1.0));
    return w.xyz / w.w;
}

// one bilinear PCF tap from four gathered depths (reversed z: bigger is closer to the light)
float Tap(float2 uv, float z, float size)
{
    float2 t = uv * size - 0.5;
    float2 f = frac(t);
    float4 d = shadowTex.GatherRed(sPt, (floor(t) + 1.0) / size);
    float4 lit = step(d, z.xxxx);
    return lerp(lerp(lit.w, lit.z, f.x), lerp(lit.x, lit.y, f.x), f.y);
}

float IGN(float2 p) { return frac(52.9829189 * frac(dot(p, float2(0.06711056, 0.00583715)))); }

// penumbra width per meter between blocker and receiver, and its limits in meters
static float g_pen = -1;
static const float PENUMBRA_PER_M = 0.12, PENUMBRA_MIN = 0.5, PENUMBRA_MAX = 5.0;

// Soft shadow with a blocker search, so the edge widens with distance from what casts it
// (a cliff 50 m away gives a wide soft edge, a post at your feet a sharp one); 1 outside the covered area
float Shadow(float3 wp, float3 n, float3 l, float dither)
{
    float size, h; shadowTex.GetDimensions(size, h);
    float texelM = 2.0 * range.y / size;
    // shadow clip z per meter along the light, read from the shadow matrix
    float zPerM = length(shadowVP[2].xyz);
    float4 c = mul(shadowVP, float4(wp + n * 0.08 + l * 0.1, 1.0));
    float2 uv = c.xy * 0.5 + 0.5;
    if (flags.y > 0.5) uv.y = 1.0 - uv.y;
    if (any(uv < 0.0) || any(uv > 1.0) || c.z <= 0.0 || c.z >= 1.0) return 1.0;
    float z = c.z + flags.z;
    float rot = dither * 6.2831853;

    float found = 0, depthSum = 0;
    float searchR = PENUMBRA_MAX / texelM;
    [unroll] for (int j = 0; j < 12; j++)
    {
        float r = sqrt((j + 0.5) / 12.0);
        float a = j * 2.3999632 + rot + 1.3;
        float d = shadowTex.SampleLevel(sPt, uv + float2(cos(a), sin(a)) * r * searchR / size, 0);
        // reversed z: a blocker is closer to the light, so its depth is bigger
        if (d > z + r * PENUMBRA_MAX * zPerM) { found += 1; depthSum += d; }
    }
    if (found == 0) return 1.0;
    float blockerM = (depthSum / found - z) / max(zPerM, 1e-7);
    float penM = clamp(blockerM * PENUMBRA_PER_M, PENUMBRA_MIN, PENUMBRA_MAX);
    g_pen = blockerM;
    float radius = penM / texelM;

    float sum = 0;
    [unroll] for (int i = 0; i < 16; i++)
    {
        float r = sqrt((i + 0.5) / 16.0);
        float a = i * 2.3999632 + rot;
        // a wider tap reaches further across a sloped receiver, so it needs more depth slack
        sum += Tap(uv + float2(cos(a), sin(a)) * r * radius / size, z + r * penM * zPerM, size);
    }
    float s = sum / 16.0;
    // fade out at the edge of the shadow camera so the cut is not visible
    float2 e = saturate((0.5 - abs(uv - 0.5)) * 10.0);
    return lerp(1.0, s, min(e.x, e.y));
}

float TimeBrightness() { return max(light.w, 0.0); }
float SunVisibility() { return saturate(light.w * 10.0 + 0.5); }

float3 SunCol()
{
    float dfade = 1.0 - pow(1.0 - TimeBrightness(), 1.5);
    float3 m = float3(255, 160, 80) * LIGHT_MI / 255.0;
    float3 d = float3(196, 220, 255) * LIGHT_DI / 255.0;
    float3 e = float3(255, 160, 80) * LIGHT_EI / 255.0;
    float3 n = float3(96, 192, 255) * LIGHT_NI * 0.3 / 255.0;
    float3 c = lerp(n, lerp(lerp(m, e, misc.x), d, dfade), SunVisibility());
    return c * c;
}

float3 AmbientCol()
{
    float dfade = 1.0 - pow(1.0 - TimeBrightness(), 1.5);
    float3 m = float3(255, 204, 144) * AMBIENT_MI / 255.0;
    float3 d = float3(120, 172, 255) * AMBIENT_DI / 255.0;
    float3 e = float3(255, 204, 144) * AMBIENT_EI / 255.0;
    float3 n = float3(96, 192, 255) * AMBIENT_NI * 0.03 / 255.0;
    float3 c = lerp(n, lerp(lerp(m, e, misc.x), d, dfade), SunVisibility());
    return c * c;
}

// BSL GGX, Schlick fresnel with a dielectric floor
float GGX(float3 n, float3 l, float3 v, float smooth, float f0)
{
    float rough = max(1.0 - smooth, 0.05); rough *= rough;
    float3 h = normalize(l + v);
    float nl = saturate(dot(n, l)), nv = saturate(dot(n, v)), nh = saturate(dot(n, h)), lh = saturate(dot(l, h));
    float a2 = rough * rough;
    float den = nh * nh * (a2 - 1.0) + 1.0;
    float D = a2 / (3.14159265 * den * den);
    float F = f0 + (1.0 - f0) * pow(1.0 - lh, 5.0);
    float k = rough * 0.5;
    float G = 1.0 / ((nl * (1.0 - k) + k) * (nv * (1.0 - k) + k));
    return D * F * G * nl * 0.25;
}

float4 PS(float4 pos : SV_Position) : SV_Target
{
    float2 tuv = pos.xy / rt.xy;
    float4 src = lightTex.SampleLevel(sPt, tuv, 0);
    float z = depthTex.SampleLevel(sPt, tuv, 0);
    if (z <= 1e-7) return src;

    float4 a = gb0.SampleLevel(sPt, tuv, 0);
    float4 s = gb1.SampleLevel(sPt, tuv, 0);
    float3 n = normalize(gb2.SampleLevel(sPt, tuv, 0).xyz * 2.0 - 1.0);

    float2 suv = (pos.xy - rt.zw) / vp.xy;
    float2 ndc = float2(suv.x * 2.0 - 1.0, flags.x > 0.5 ? suv.y * 2.0 - 1.0 : 1.0 - suv.y * 2.0);
    float3 wp = ToWorld(ndc, z);
    float3 v = normalize(cam.xyz - wp);
    float3 l = normalize(light.xyz);

    // wrapped so the line where a surface turns away from the sun fades instead of cutting
    float nl = saturate((dot(n, l) + 0.25) / 1.25);
    // use the shadow the game itself drew when the plugin has it (vp.zw = mask size); our sun map only when SUN_MAP_FALLBACK is set
    static const bool SUN_MAP_FALLBACK = false;
    // HLSL evaluates both sides of ?:, so a real branch keeps the 28-tap sun map lookup from running every frame
    float sh = 1.0;
    [branch] if (vp.z > 0) sh = maskTex.SampleLevel(sPt, pos.xy / vp.zw, 0).r;
    else if (SUN_MAP_FALLBACK) sh = Shadow(wp, n, l, frac(IGN(pos.xy) + 0.61803398875 * fmod(flags.w, 3600.0)));
    float lit = nl * sh;

    int mode = (int)rl.w;
    if (mode == 1) return float4(lit.xxx, src.a);
    if (mode == 9) return float4(sh.xxx, src.a);
    if (mode == 7) return float4(g_pen < 0 ? float3(0, 0, 1) : float3(saturate(g_pen / 100), frac(g_pen / 10), 0), src.a);
    if (mode == 2) return float4(n * 0.5 + 0.5, src.a);
    if (mode == 8) return float4(suv.x < 0.5 ? light.xyz * 0.5 + 0.5 : float3(light.w * 0.5 + 0.5, misc.x, range.y / 1000), 1);
    if (mode == 3) return float4(a.rgb, src.a);
    if (mode == 4) return float4(s.rgb, src.a);
    if (mode == 5) return float4(s.aaa, src.a);

    float3 L = Lin(src.rgb);
    float3 alb = Lin(a.rgb);
    // what the game's lights delivered to this pixel, color removed
    float3 E = L / max(alb, 0.02);
    float Y = Lum(E);
    if (mode == 6) return float4(pow(saturate(E * 0.5), 1.0 / 2.2), src.a);

    float3 sunC = SunCol(), ambC = AmbientCol();
    // the squared BSL sun color reads too blue at noon on snow; its square root keeps the hue but halves the push
    float3 sunT = sqrt(sunC) / max(Lum(sqrt(sunC)), 1e-4);
    // BSL's tonemap warms its noon sun; without that tonemap the raw day color looks cold on snow
    sunT = lerp(sunT, float3(1.06, 1.0, 0.9), 0.6);
    float3 ambT = ambC / max(Lum(ambC), 1e-4);
    // TLD lights the world almost flat, so the game light is kept as the sky light everywhere (shade is not darkened)
    // and BSL-style sunlight is added on top where the surface faces the sun and the game has no shadow.
    // contrast 2 adds 60% more light on fully lit surfaces.
    float k = rl.z * SunVisibility();
    float3 lightMul = lerp(1.0, ambT, 0.45 * saturate(rl.x)) + 0.3 * k * lit * lerp(1.0, sunT, saturate(rl.x));
    float3 E2 = E * lightMul;
    float3 outL = lerp(L, alb * E2, step(0.02, Lum(alb)));
    // the added sun pushes snow past white; roll the top off softly toward 1 so it keeps its shading
    float yo = Lum(outL), yc = yo < 0.75 ? yo : 0.75 + (yo - 0.75) / (1.0 + (yo - 0.75) / 0.3);
    outL *= yc / max(yo, 1e-4);

    float f0 = max(Lum(s.rgb), 0.02);
    float spec = GGX(n, l, v, s.a, f0) * sh * rl.y;
    // the sun term is scaled to the game's lighting level, read from the lit pixels' irradiance
    outL += sunT * spec * max(Y, 0.25) * SunVisibility() * a.a;

    return float4(pow(outL, 1.0 / 2.2), src.a);
}
