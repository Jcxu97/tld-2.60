// LightPlus composite pass. Saved edits recompile on the next frame.
// Light shafts follow BSL v10.1.8 (lib/atmospherics/lightShafts.glsl, overworld path),
// with the settings from the user's BSL_v10.1.8.zip.txt (LIGHT_DI 1.15, LIGHT_MI 1.00, LIGHT_EI 1.00, LIGHT_NI 0.85).

cbuffer P : register(b0)
{
    row_major float4x4 invVP;     // clip -> world, main camera
    row_major float4x4 shadowVP;  // world -> clip, LightPlus shadow camera
    float4 cam;      // xyz camera position, w time
    float4 light;    // xyz direction toward the shaft light (sun or moon), w sun height (SdotU)
    float4 tune;     // x shaft strength, y unused, z rain, w eye brightness
    float4 range;    // x max distance, y shadow range, z samples, w debug mode
    float4 flags;    // x screen flip y, y shadow flip y, z shadow bias, w frame
    float4 misc;     // x evening (1) or morning (0), y camera near plane, z shafts on, w grade on
    float4 pad1;
    float4 rt;       // filled by the plugin: target w h, viewport x y
    float4 vp;       // filled by the plugin: viewport w h, mask w h
    float4 rl;       // relight settings, unused here
    float4 gr;       // grade: x mix, y split tone, z contrast, w sunlit boost
    float4 gr2;      // grade: x vibrance, y vignette, z sun glow
    row_major float4x4 VP;        // world -> clip, main camera
    float4 rf;       // reflections: x strength, y min smoothness, z max distance, w on
};

Texture2D colorTex : register(t0);
Texture2D<float> depthTex : register(t1);
Texture2D<float> shadowTex : register(t2);
Texture2D gb1 : register(t4);       // specular rgb, smoothness a, this frame
Texture2D gb2 : register(t5);       // world normal * 0.5 + 0.5, this frame
Texture2D maskTex : register(t6);   // the game's screen-space sun shadow, 1 lit
SamplerState sLin : register(s0);
SamplerState sPt : register(s1);

static const float LIGHT_MI = 1.00, LIGHT_DI = 1.15, LIGHT_EI = 1.00, LIGHT_NI = 0.85;
static const float LIGHT_SHAFT_STRENGTH = 1.00;
static const float LIGHT_SHAFT_MORNING_FALLOFF = 0.25, LIGHT_SHAFT_DAY_FALLOFF = 0.10;
static const float LIGHT_SHAFT_NIGHT_FALLOFF = 0.50, LIGHT_SHAFT_WEATHER_FALLOFF = 8.0;

// BSL composite5 color path with the user's settings (VIBRANCE 1.10, default tonemap curves)
static const bool BSL_COLOR = false;
static const float EXPOSURE = 0.0;
static const float TONEMAP_LOWER_CURVE = 1.0, TONEMAP_UPPER_CURVE = 1.0, TONEMAP_WHITE_CURVE = 2.0;
static const float SATURATION = 1.00;

float3 BSLTonemap(float3 color)
{
    color *= exp2(2.0 + EXPOSURE);
    const float3x3 desat = float3x3(0.96, 0.03, 0.01, 0.03, 0.94, 0.03, 0.01, 0.03, 0.96);
    const float3x3 sat = float3x3(1.0427993, -0.032967, -0.0098323, -0.032967, 1.0659341, -0.032967, -0.0098323, -0.032967, 1.0427993);
    color = mul(color, desat);
    color = color / pow(pow(color, TONEMAP_WHITE_CURVE) + 1.0, 1.0 / TONEMAP_WHITE_CURVE);
    color = pow(color, lerp(TONEMAP_LOWER_CURVE.xxx, TONEMAP_UPPER_CURVE.xxx, sqrt(color)));
    color = mul(color, sat);
    return saturate(color);
}

float3 ColorSaturation(float3 color)
{
    float grayVibrance = (color.r + color.g + color.b) / 3.0;
    float graySaturation = dot(color, float3(0.299, 0.587, 0.114));
    float mn = min(color.r, min(color.g, color.b));
    float mx = max(color.r, max(color.g, color.b));
    float sat = (1.0 - (mx - mn)) * (1.0 - mx) * grayVibrance * 5.0;
    float3 lightness = (mn + mx) * 0.5;
    float vib = gr2.x;
    color = lerp(color, lerp(color, lightness, 1.0 - vib), sat);
    color = lerp(color, lightness, (1.0 - lightness) * (2.0 - vib) / 2.0 * abs(vib - 1.0));
    return color * SATURATION - graySaturation * (SATURATION - 1.0);
}

float IGN(float2 p) { return frac(52.9829189 * frac(dot(p, float2(0.06711056, 0.00583715)))); }

float3 ToWorld(float2 ndc, float z)
{
    float4 w = mul(invVP, float4(ndc, z, 1.0));
    return w.xyz / w.w;
}

float3 ShadowPos(float3 wp)
{
    float4 c = mul(shadowVP, float4(wp, 1.0));
    float2 uv = c.xy * 0.5 + 0.5;
    if (flags.y > 0.5) uv.y = 1.0 - uv.y;
    return float3(uv, c.z);
}

float ShadowAt(float3 wp)
{
    float3 s = ShadowPos(wp);
    if (any(s.xy < 0.0) || any(s.xy > 1.0) || s.z <= 0.0 || s.z >= 1.0) return 1.0;
    float d = shadowTex.SampleLevel(sPt, s.xy, 0);
    // reversed z: a bigger value is closer to the light
    return s.z + flags.z >= d ? 1.0 : 0.0;
}

float TimeBrightness() { return max(light.w, 0.0); }
float SunVisibility() { return saturate(light.w * 10.0 + 0.5); }

float3 LightCol(float rain)
{
    float timeBrightness = TimeBrightness();
    float mefade = misc.x;
    float dfade = 1.0 - pow(1.0 - timeBrightness, 1.5);
    float3 lightMorning = float3(255, 160, 80) * LIGHT_MI / 255.0;
    float3 lightDay = float3(196, 220, 255) * LIGHT_DI / 255.0;
    float3 lightEvening = float3(255, 160, 80) * LIGHT_EI / 255.0;
    float3 lightNight = float3(96, 192, 255) * LIGHT_NI * 0.3 / 255.0;
    float3 weatherCol = float3(176, 224, 255) / 255.0 * 1.20;
    float3 lightSun = lerp(lerp(lightMorning, lightEvening, mefade), lightDay, dfade);
    float3 raw = lerp(lightNight, lightSun, SunVisibility());
    float3 sq = lerp(raw, dot(raw, float3(0.299, 0.587, 0.114)) * weatherCol, rain);
    return sq * sq;
}

float Falloff(float3 nv, float rain, float eBS)
{
    float VoL = dot(nv, light.xyz);
    float factor = lerp(LIGHT_SHAFT_MORNING_FALLOFF, LIGHT_SHAFT_DAY_FALLOFF, TimeBrightness());
    factor = lerp(LIGHT_SHAFT_NIGHT_FALLOFF, factor, SunVisibility());
    factor *= lerp(1.0, LIGHT_SHAFT_WEATHER_FALLOFF, rain) * 0.1;
    factor = min(factor, 0.999);
    float reverseFactor = 1.0 - factor;
    float falloff = saturate(VoL * 0.5 + 0.5);
    falloff = factor / (1.0 - reverseFactor * falloff) - factor;
    falloff = saturate(falloff * 1.015 / reverseFactor - 0.015);
    return lerp(1.0, falloff, 0.03125 * eBS + 0.96875);
}

// BSL GetLightShafts: exponential steps out to 128 m, stop at the first opaque surface
float3 LightShafts(float linZ, float3 nv, float dither)
{
    float rain = tune.z, eBS = tune.w;
    float falloff = Falloff(nv, rain, eBS);
    if (falloff <= 0.0) return 0;
    float maxDist = range.x;
    int n = max((int)range.z, 1);
    float stepScale = 7.0 / n;
    float total = 0.0;
    [loop] for (int i = 0; i < n; i++)
    {
        float currentDist = exp2((i + dither) * stepScale) - 0.95;
        if (currentDist >= maxDist || currentDist > linZ) break;
        total += ShadowAt(cam.xyz + nv * currentDist);
    }
    float3 shafts = total * falloff * LightCol(rain) * 0.25;
    shafts *= LIGHT_SHAFT_STRENGTH * (1.0 - rain * eBS * 0.875);
    return shafts / n;
}

// BSL-style look on the final image: sun glow in the air, warm lights and cool shadows,
// a soft contrast curve, vibrance and vignette. All strengths come from gr and gr2 (the in-game panel).
float3 Grade(float3 lin, float3 nv, float dist, float2 suv, float sunlit)
{
    float3 gp = gr.yzw;
    // extra light on surfaces the sun really reaches, faded with distance so the game's fog stays as it is; kept neutral white (the user found the warm tint too orange)
    lin *= 1.0 + gp.z * sunlit * exp(-dist / 250.0) * float3(1.0, 1.0, 0.97);
    float VoL = saturate(dot(nv, light.xyz));
    float haze = 1.0 - exp(-dist / 350.0);
    float3 sunAir = sqrt(LightCol(0.0));
    lin += sunAir * pow(VoL, 8.0) * haze * gr2.z * SunVisibility();

    float y = dot(lin, float3(0.299, 0.587, 0.114));
    float3 warm = float3(1.01, 1.0, 0.98), cool = float3(0.93, 0.98, 1.07);
    lin *= lerp(1.0, lerp(cool, warm, smoothstep(0.04, 0.55, y)), gp.x * SunVisibility());

    float3 g = pow(max(lin, 0), 1.0 / 2.2);
    g = lerp(g, g * g * (3.0 - 2.0 * g), gp.y * saturate(1.0 - g));
    g = ColorSaturation(saturate(g));
    float r = length(suv - 0.5) * 1.414;
    g *= 1.0 - gr2.y * 0.3 * pow(r, 2.5);
    return g;
}

// Screen-space reflections on flat smooth ground (frozen lakes, wet floors), in the BSL water style:
// march the reflected ray through the depth buffer, take the color where it hits, and blend by fresnel.
// ponytail: 20 growing steps and 4 refine steps, no hierarchy; enough for flat ice, a Hi-Z march would cost less on large surfaces
float2 ToScreen(float3 w)
{
    float4 c = mul(VP, float4(w, 1.0));
    float2 ndc = c.xy / c.w;
    float2 suv = float2(ndc.x * 0.5 + 0.5, flags.x > 0.5 ? ndc.y * 0.5 + 0.5 : 0.5 - ndc.y * 0.5);
    return suv;
}

float RayDepth(float3 w) { float4 c = mul(VP, float4(w, 1.0)); return c.z / c.w; }

float4 Reflect(float3 wp, float3 n, float3 nv, float dither)
{
    float3 r = reflect(nv, n);
    if (r.y < 0.02) return 0;
    float stepLen = 0.4, t = stepLen * (0.5 + dither);
    float3 prev = wp;
    [loop] for (int i = 0; i < 20; i++)
    {
        float3 p = wp + r * t;
        float2 suv = ToScreen(p);
        if (any(suv < 0.0) || any(suv > 1.0) || t > rf.z) break;
        float2 tuv = (suv * vp.xy + rt.zw) / rt.xy;
        float sceneZ = depthTex.SampleLevel(sPt, tuv, 0);
        float rayZ = RayDepth(p);
        // reversed z: the ray went behind the scene surface when its depth drops below the stored one
        if (rayZ < sceneZ && sceneZ > 1e-7)
        {
            float3 a = prev, b = p;
            [unroll] for (int k = 0; k < 4; k++)
            {
                float3 m = (a + b) * 0.5;
                float2 mu = (ToScreen(m) * vp.xy + rt.zw) / rt.xy;
                if (RayDepth(m) < depthTex.SampleLevel(sPt, mu, 0)) b = m; else a = m;
            }
            float2 hs = ToScreen(b);
            float2 hu = (hs * vp.xy + rt.zw) / rt.xy;
            // a hit far behind the surface is a thin object seen from the side, not a real reflection
            float thick = abs(length(b - cam.xyz) - length(ToWorld(float2(hs.x * 2.0 - 1.0, flags.x > 0.5 ? hs.y * 2.0 - 1.0 : 1.0 - hs.y * 2.0), depthTex.SampleLevel(sPt, hu, 0)) - cam.xyz));
            if (thick > 1.5 + t * 0.1) return 0;
            float2 e = saturate((0.5 - abs(hs - 0.5)) * 8.0);
            float fade = min(e.x, e.y) * saturate(1.0 - t / rf.z);
            return float4(colorTex.SampleLevel(sLin, hu, 0).rgb, fade);
        }
        prev = p;
        t += stepLen;
        stepLen *= 1.3;
    }
    return 0;
}

float4 PS(float4 pos : SV_Position) : SV_Target
{
    float2 tuv = pos.xy / rt.xy;
    float4 src = colorTex.SampleLevel(sPt, tuv, 0);
    float3 color = src.rgb;
    float z = depthTex.SampleLevel(sPt, tuv, 0);
    float2 suv = (pos.xy - rt.zw) / vp.xy;
    float2 ndc = float2(suv.x * 2.0 - 1.0, flags.x > 0.5 ? suv.y * 2.0 - 1.0 : 1.0 - suv.y * 2.0);
    bool sky = z <= 1e-7;
    float3 wp = ToWorld(ndc, sky ? 1e-7 : z);
    float3 v = wp - cam.xyz;
    float lv = length(v);
    float3 nv = v / lv;
    if (sky) lv = 1e6;

    int mode = (int)range.w;
    if (mode == 5) return float4(1, 0, 1, 1);
    if (mode == 9) { float d = shadowTex.SampleLevel(sPt, suv, 0); return float4(d * 2, frac(d * 50), d > 0 ? 1 : 0, 1); }
    if (mode == 6) return float4(saturate(z * 200).xxx, 1);
    if (mode == 7) return float4(nv * 0.5 + 0.5, 1);
    if (mode == 8) return float4(saturate(lv / 200).xxx, 1);
    if (mode == 1) return float4(frac(wp * 0.1), src.a);
    if (mode == 2) return float4(color * (0.25 + 0.75 * ShadowAt(wp)), src.a);
    if (mode == 3) { float3 s = ShadowPos(wp); return float4(saturate(s.xy), shadowTex.SampleLevel(sPt, saturate(s.xy), 0) * 20, src.a); }

    float dither = frac(IGN(pos.xy) + 0.61803398875 * fmod(flags.w, 3600.0));
    float3 vl = misc.z > 0.5 ? LightShafts(lv, nv, dither) : 0;
    if (mode == 4) return float4(vl * tune.x * 4.0, src.a);

    // TLD shades in gamma space; BSL adds shafts to linear color, so convert around the add
    // BSL multiplies the scene by 4 in its tonemap, so shafts need the same 4x next to TLD colors
    float3 lin = pow(max(color, 0), 2.2) + vl * tune.x * 4.0;
    if (rf.w > 0.5 && !sky)
    {
        float3 n = normalize(gb2.SampleLevel(sPt, tuv, 0).xyz * 2.0 - 1.0);
        float smooth = gb1.SampleLevel(sPt, tuv, 0).a;
        if (mode == 13) return float4(smooth.xxx, src.a);
        [branch] if (n.y > 0.8 && smooth >= rf.y)
        {
            float4 hit = Reflect(wp, n, nv, dither);
            float fres = 0.04 + 0.96 * pow(1.0 - saturate(dot(-nv, n)), 5.0);
            float w = saturate(hit.a * rf.x * (0.35 + 0.65 * fres) * saturate((smooth - rf.y) / max(1.0 - rf.y, 0.01) * 2.0));
            lin = lerp(lin, pow(max(hit.rgb, 0), 2.2), w);
            if (mode == 14) return float4(w.xxx, src.a);
        }
    }
    if (misc.w < 0.5) return float4(pow(lin, 1.0 / 2.2), src.a);
    float sunlit = 0;
    if (!sky)
    {
        float3 nrm = normalize(gb2.SampleLevel(sPt, tuv, 0).xyz * 2.0 - 1.0);
        float m = vp.z > 0 ? maskTex.SampleLevel(sPt, pos.xy / vp.zw, 0).r : 1.0;
        sunlit = m * saturate(dot(nrm, light.xyz)) * SunVisibility();
    }
    float3 graded = Grade(lin, nv, lv, suv, sunlit);
    return float4(lerp(pow(lin, 1.0 / 2.2), graded, gr.x), src.a);
}

