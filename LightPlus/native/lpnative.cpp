// LightPlus native pass: runs hot-reloaded HLSL on the camera target from a Unity CommandBuffer plugin event.
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <d3d11_1.h>
#include <d3dcompiler.h>
#include <cstdio>
#include <cstring>
#include <string>
#include <mutex>
#include <cstdint>

#define EXPORT extern "C" __declspec(dllexport)

static const int kParamFloats = 256;

static std::wstring g_dir;
static std::mutex g_logMx;
static ID3D11Device* g_dev;
static ID3D11Device1* g_dev1;
static ID3D11DeviceContext1* g_ctx1;
static ID3DDeviceContextState* g_state;
static ID3D11VertexShader* g_vs;
static ID3D11Buffer* g_cb;
static ID3D11SamplerState* g_sampLinear;
static ID3D11SamplerState* g_sampPoint;
static ID3D11RasterizerState* g_rs;
static ID3D11DepthStencilState* g_dss;
static ID3D11BlendState* g_bs;

struct Copy { ID3D11Texture2D* tex = nullptr; ID3D11ShaderResourceView* srv = nullptr; D3D11_TEXTURE2D_DESC desc{}; };
static Copy g_color, g_depth;
static ID3D11Resource* g_shadowRes;
static ID3D11ShaderResourceView* g_shadowSrv;
static void* g_shadowPtr;
static int g_logged;
static bool g_ready;
static DWORD g_faultCode;

static void Log(const char* fmt, ...)
{
    std::lock_guard<std::mutex> lk(g_logMx);
    FILE* f = _wfopen((g_dir + L"\\native.log").c_str(), L"a");
    if (!f) return;
    SYSTEMTIME t; GetLocalTime(&t);
    fprintf(f, "%02d:%02d:%02d ", t.wHour, t.wMinute, t.wSecond);
    va_list a; va_start(a, fmt); vfprintf(f, fmt, a); va_end(a);
    fputc('\n', f);
    fclose(f);
}

template <class T> static void Rel(T*& p) { if (p) { p->Release(); p = nullptr; } }

static DXGI_FORMAT SrvFormat(DXGI_FORMAT f)
{
    switch (f)
    {
    case DXGI_FORMAT_R24G8_TYPELESS: case DXGI_FORMAT_D24_UNORM_S8_UINT: return DXGI_FORMAT_R24_UNORM_X8_TYPELESS;
    case DXGI_FORMAT_R32G8X24_TYPELESS: case DXGI_FORMAT_D32_FLOAT_S8X24_UINT: return DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS;
    case DXGI_FORMAT_R32_TYPELESS: case DXGI_FORMAT_D32_FLOAT: return DXGI_FORMAT_R32_FLOAT;
    case DXGI_FORMAT_R16_TYPELESS: case DXGI_FORMAT_D16_UNORM: return DXGI_FORMAT_R16_UNORM;
    case DXGI_FORMAT_R16G16B16A16_TYPELESS: return DXGI_FORMAT_R16G16B16A16_FLOAT;
    case DXGI_FORMAT_R8G8B8A8_TYPELESS: return DXGI_FORMAT_R8G8B8A8_UNORM;
    case DXGI_FORMAT_B8G8R8A8_TYPELESS: return DXGI_FORMAT_B8G8R8A8_UNORM;
    case DXGI_FORMAT_R10G10B10A2_TYPELESS: return DXGI_FORMAT_R10G10B10A2_UNORM;
    case DXGI_FORMAT_R32G32B32A32_TYPELESS: return DXGI_FORMAT_R32G32B32A32_FLOAT;
    default: return f;
    }
}

static DXGI_FORMAT CopyFormat(DXGI_FORMAT f)
{
    switch (f)
    {
    case DXGI_FORMAT_D24_UNORM_S8_UINT: return DXGI_FORMAT_R24G8_TYPELESS;
    case DXGI_FORMAT_D32_FLOAT_S8X24_UINT: return DXGI_FORMAT_R32G8X24_TYPELESS;
    case DXGI_FORMAT_D32_FLOAT: return DXGI_FORMAT_R32_TYPELESS;
    case DXGI_FORMAT_D16_UNORM: return DXGI_FORMAT_R16_TYPELESS;
    default: return f;
    }
}

static bool CopyOf(Copy& c, ID3D11Resource* src, const char* name)
{
    ID3D11Texture2D* t = nullptr;
    if (FAILED(src->QueryInterface(__uuidof(ID3D11Texture2D), (void**)&t))) return false;
    D3D11_TEXTURE2D_DESC d; t->GetDesc(&d); t->Release();
    if (!c.tex || d.Width != c.desc.Width || d.Height != c.desc.Height || d.Format != c.desc.Format)
    {
        Rel(c.srv); Rel(c.tex);
        c.desc = d;
        D3D11_TEXTURE2D_DESC n = d;
        n.Format = CopyFormat(d.Format);
        n.BindFlags = D3D11_BIND_SHADER_RESOURCE;
        n.MiscFlags = 0; n.CPUAccessFlags = 0; n.Usage = D3D11_USAGE_DEFAULT; n.MipLevels = 1;
        if (d.MipLevels != 1 || d.SampleDesc.Count != 1) { Log("%s: unsupported mips=%u samples=%u", name, d.MipLevels, d.SampleDesc.Count); return false; }
        HRESULT hr = g_dev->CreateTexture2D(&n, nullptr, &c.tex);
        if (SUCCEEDED(hr)) hr = g_dev->CreateShaderResourceView(c.tex, nullptr, &c.srv);
        if (FAILED(hr))
        {
            D3D11_SHADER_RESOURCE_VIEW_DESC sd{}; sd.Format = SrvFormat(d.Format); sd.ViewDimension = D3D11_SRV_DIMENSION_TEXTURE2D; sd.Texture2D.MipLevels = 1;
            hr = c.tex ? g_dev->CreateShaderResourceView(c.tex, &sd, &c.srv) : hr;
        }
        Log("%s copy %ux%u fmt=%d bind=0x%x hr=0x%08x", name, d.Width, d.Height, (int)d.Format, d.BindFlags, (unsigned)hr);
        if (FAILED(hr)) { Rel(c.srv); Rel(c.tex); return false; }
    }
    g_ctx1->CopyResource(c.tex, src);
    return true;
}

static float Half(uint16_t h)
{
    uint32_t s = (h & 0x8000u) << 16, e = (h >> 10) & 0x1f, m = h & 0x3ff, f;
    if (e == 0) { if (!m) f = s; else { e = 113; while (!(m & 0x400)) { m <<= 1; e--; } f = s | (e << 23) | ((m & 0x3ff) << 13); } }
    else if (e == 31) f = s | 0x7f800000u | (m << 13);
    else f = s | ((e + 112) << 23) | (m << 13);
    float r; memcpy(&r, &f, 4); return r;
}

// Writes a quarter-size BMP of an RGBA16F texture, so frames can be checked without the game in front.
static void SaveBmp(ID3D11Resource* res, const wchar_t* name)
{
    ID3D11Texture2D* t = nullptr;
    if (FAILED(res->QueryInterface(__uuidof(ID3D11Texture2D), (void**)&t))) return;
    D3D11_TEXTURE2D_DESC d; t->GetDesc(&d); t->Release();
    if (d.Format != DXGI_FORMAT_R16G16B16A16_TYPELESS && d.Format != DXGI_FORMAT_R16G16B16A16_FLOAT) { Log("capture: format %d not handled", (int)d.Format); return; }
    D3D11_TEXTURE2D_DESC sd = d; sd.Usage = D3D11_USAGE_STAGING; sd.BindFlags = 0; sd.CPUAccessFlags = D3D11_CPU_ACCESS_READ; sd.MiscFlags = 0; sd.MipLevels = 1;
    ID3D11Texture2D* st = nullptr;
    if (FAILED(g_dev->CreateTexture2D(&sd, nullptr, &st))) return;
    g_ctx1->CopyResource(st, res);
    D3D11_MAPPED_SUBRESOURCE m;
    if (SUCCEEDED(g_ctx1->Map(st, 0, D3D11_MAP_READ, 0, &m)))
    {
        int w = d.Width / 4, h = d.Height / 4, stride = (w * 3 + 3) & ~3;
        std::string px((size_t)stride * h, '\0');
        for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++)
            {
                const uint16_t* s = (const uint16_t*)((const char*)m.pData + (size_t)(y * 4) * m.RowPitch) + (size_t)x * 16;
                unsigned char* o = (unsigned char*)&px[(size_t)(h - 1 - y) * stride + x * 3];
                for (int c = 0; c < 3; c++) { float v = Half(s[2 - c]); v = v != v ? 1.f : v < 0 ? 0 : v > 1 ? 1 : v; o[c] = (unsigned char)(v * 255.f + 0.5f); }
            }
        g_ctx1->Unmap(st, 0);
        BITMAPFILEHEADER fh{}; BITMAPINFOHEADER ih{};
        fh.bfType = 0x4d42; fh.bfOffBits = sizeof(fh) + sizeof(ih); fh.bfSize = fh.bfOffBits + (DWORD)px.size();
        ih.biSize = sizeof(ih); ih.biWidth = w; ih.biHeight = h; ih.biPlanes = 1; ih.biBitCount = 24;
        FILE* f = _wfopen((g_dir + L"\\" + name).c_str(), L"wb");
        if (f) { fwrite(&fh, sizeof(fh), 1, f); fwrite(&ih, sizeof(ih), 1, f); fwrite(px.data(), 1, px.size(), f); fclose(f); }
    }
    st->Release();
}

struct Pass { const wchar_t* file; ID3D11PixelShader* ps; FILETIME time; };
static Pass g_passes[] = { { L"composite.hlsl" }, { L"relight.hlsl" } };

static ID3D11PixelShader* CompilePs(int idx)
{
    Pass& p = g_passes[idx];
    std::wstring path = g_dir + L"\\shaders\\" + p.file;
    WIN32_FILE_ATTRIBUTE_DATA fa;
    if (!GetFileAttributesExW(path.c_str(), GetFileExInfoStandard, &fa)) return p.ps;
    if (p.ps && CompareFileTime(&fa.ftLastWriteTime, &p.time) == 0) return p.ps;
    p.time = fa.ftLastWriteTime;
    ID3DBlob *code = nullptr, *err = nullptr;
    HRESULT hr = D3DCompileFromFile(path.c_str(), nullptr, D3D_COMPILE_STANDARD_FILE_INCLUDE, "PS", "ps_5_0", D3DCOMPILE_OPTIMIZATION_LEVEL3, 0, &code, &err);
    if (FAILED(hr)) { Log("%ls compile failed 0x%08x: %s", p.file, (unsigned)hr, err ? (const char*)err->GetBufferPointer() : ""); Rel(err); return p.ps; }
    ID3D11PixelShader* ps = nullptr;
    hr = g_dev->CreatePixelShader(code->GetBufferPointer(), code->GetBufferSize(), nullptr, &ps);
    Rel(code); Rel(err);
    if (FAILED(hr)) { Log("CreatePixelShader 0x%08x", (unsigned)hr); return p.ps; }
    Rel(p.ps); p.ps = ps;
    Log("%ls compiled", p.file);
    return p.ps;
}

static const char* kVs =
    "float4 VS(uint id : SV_VertexID) : SV_Position {"
    " float2 p = float2((id << 1) & 2, id & 2); return float4(p * float2(2, -2) + float2(-1, 1), 0, 1); }";

static bool Init(ID3D11Device* dev)
{
    if (g_dev) return g_ready;
    g_dev = dev;
    ID3D11DeviceContext* ctx = nullptr;
    dev->GetImmediateContext(&ctx);
    ctx->QueryInterface(__uuidof(ID3D11DeviceContext1), (void**)&g_ctx1);
    ctx->Release();
    dev->QueryInterface(__uuidof(ID3D11Device1), (void**)&g_dev1);
    if (!g_ctx1 || !g_dev1) { Log("no D3D11.1 context"); return false; }
    D3D_FEATURE_LEVEL fl = dev->GetFeatureLevel(), got;
    HRESULT hr = g_dev1->CreateDeviceContextState(0, &fl, 1, D3D11_SDK_VERSION, __uuidof(ID3D11Device1), &got, &g_state);
    if (FAILED(hr)) { Log("CreateDeviceContextState 0x%08x", (unsigned)hr); return false; }

    ID3DBlob *code = nullptr, *err = nullptr;
    hr = D3DCompile(kVs, strlen(kVs), "vs", nullptr, nullptr, "VS", "vs_5_0", 0, 0, &code, &err);
    if (FAILED(hr)) { Log("vs compile: %s", err ? (const char*)err->GetBufferPointer() : ""); return false; }
    dev->CreateVertexShader(code->GetBufferPointer(), code->GetBufferSize(), nullptr, &g_vs);
    Rel(code); Rel(err);

    D3D11_BUFFER_DESC bd{}; bd.ByteWidth = kParamFloats * 4; bd.Usage = D3D11_USAGE_DYNAMIC; bd.BindFlags = D3D11_BIND_CONSTANT_BUFFER; bd.CPUAccessFlags = D3D11_CPU_ACCESS_WRITE;
    dev->CreateBuffer(&bd, nullptr, &g_cb);
    D3D11_SAMPLER_DESC sd{}; sd.Filter = D3D11_FILTER_MIN_MAG_MIP_LINEAR; sd.AddressU = sd.AddressV = sd.AddressW = D3D11_TEXTURE_ADDRESS_CLAMP; sd.MaxLOD = D3D11_FLOAT32_MAX;
    dev->CreateSamplerState(&sd, &g_sampLinear);
    sd.Filter = D3D11_FILTER_MIN_MAG_MIP_POINT;
    dev->CreateSamplerState(&sd, &g_sampPoint);
    D3D11_RASTERIZER_DESC rd{}; rd.FillMode = D3D11_FILL_SOLID; rd.CullMode = D3D11_CULL_NONE; rd.DepthClipEnable = TRUE;
    dev->CreateRasterizerState(&rd, &g_rs);
    D3D11_DEPTH_STENCIL_DESC dd{}; dev->CreateDepthStencilState(&dd, &g_dss);
    D3D11_BLEND_DESC bld{}; bld.RenderTarget[0].RenderTargetWriteMask = D3D11_COLOR_WRITE_ENABLE_ALL; dev->CreateBlendState(&bld, &g_bs);
    g_ready = g_vs && g_cb && g_state;
    Log("init ok=%d, feature level 0x%x", (int)g_ready, (unsigned)fl);
    return true;
}

static void UpdateShadowSrv()
{
    if (g_shadowPtr == g_shadowRes && g_shadowSrv) return;
    Rel(g_shadowSrv);
    g_shadowRes = (ID3D11Resource*)g_shadowPtr;
    if (!g_shadowRes) return;
    ID3D11Texture2D* t = nullptr;
    if (FAILED(g_shadowRes->QueryInterface(__uuidof(ID3D11Texture2D), (void**)&t))) return;
    D3D11_TEXTURE2D_DESC d; t->GetDesc(&d);
    D3D11_SHADER_RESOURCE_VIEW_DESC sd{}; sd.Format = SrvFormat(d.Format); sd.ViewDimension = D3D11_SRV_DIMENSION_TEXTURE2D; sd.Texture2D.MipLevels = 1;
    HRESULT hr = g_dev->CreateShaderResourceView(t, &sd, &g_shadowSrv);
    Log("shadow %ux%u fmt=%d bind=0x%x hr=0x%08x", d.Width, d.Height, (int)d.Format, d.BindFlags, (unsigned)hr);
    t->Release();
}

// the shadow map is the only resource we hold before the first event, so take the device from it
static bool Ready()
{
    if (g_ready) return true;
    if (g_dev || !g_shadowPtr) return false;
    ID3D11Device* d = nullptr;
    ((ID3D11Resource*)g_shadowPtr)->GetDevice(&d);
    bool ok = Init(d);
    d->Release();
    return ok;
}

static Copy g_gb[3], g_mask;
static unsigned g_gbSeq, g_maskSeq;

static void SaveDepth()
{
    if (!Ready()) return;
    ID3D11RenderTargetView* rtv = nullptr;
    ID3D11DepthStencilView* dsv = nullptr;
    g_ctx1->OMGetRenderTargets(1, &rtv, &dsv);
    Rel(rtv);
    if (!dsv) { if (g_logged++ < 3) Log("no depth bound"); return; }
    ID3D11Resource* res = nullptr;
    dsv->GetResource(&res);
    CopyOf(g_depth, res, "depth");
    Rel(res); Rel(dsv);
}

// Unity deferred: RT0 albedo + occlusion, RT1 specular + smoothness, RT2 world normal, RT3 emission/lighting
static void SaveGBuffer(const float* params)
{
    if (!Ready()) return;
    ID3D11RenderTargetView* rtv[8] = {};
    ID3D11DepthStencilView* dsv = nullptr;
    g_ctx1->OMGetRenderTargets(8, rtv, &dsv);
    static bool logged;
    for (int i = 0; i < 8; i++)
    {
        if (!rtv[i]) continue;
        ID3D11Resource* res = nullptr; rtv[i]->GetResource(&res);
        if (!logged)
        {
            D3D11_RENDER_TARGET_VIEW_DESC rd; rtv[i]->GetDesc(&rd);
            Log("gbuffer rt%d fmt=%d res=%p", i, (int)rd.Format, (void*)res);
        }
        // albedo feeds only the relight pass (params[56]); smoothness also feeds the reflections (params[57]); the grade needs the normals
        bool need = i == 2 || (i == 0 && params[56] > 0.5f) || (i == 1 && (params[56] > 0.5f || params[57] > 0.5f));
        if (need) CopyOf(g_gb[i], res, "gbuffer");
        Rel(res); Rel(rtv[i]);
    }
    g_gbSeq++;
    if (!logged) Log("gbuffer dsv=%p", (void*)dsv);
    logged = true;
    // the relight pass runs before the depth event, so take this frame's depth here to avoid a one-frame lag
    if (dsv) { ID3D11Resource* res = nullptr; dsv->GetResource(&res); CopyOf(g_depth, res, "depth"); Rel(res); }
    Rel(dsv);
}

// Unity's screen-space shadow mask for the sun, bound as the target at LightEvent.AfterScreenspaceMask.
// Other cameras (shadow camera, probes) fire it too, so only a mask the size of the G-buffer is kept.
static void SaveMask()
{
    if (!Ready() || !g_gb[2].tex) return;
    ID3D11RenderTargetView* rtv = nullptr;
    g_ctx1->OMGetRenderTargets(1, &rtv, nullptr);
    if (!rtv) return;
    ID3D11Resource* res = nullptr; rtv->GetResource(&res);
    ID3D11Texture2D* t = nullptr;
    if (SUCCEEDED(res->QueryInterface(__uuidof(ID3D11Texture2D), (void**)&t)))
    {
        D3D11_TEXTURE2D_DESC d; t->GetDesc(&d); t->Release();
        static int logged;
        if (logged++ < 4) Log("mask %ux%u fmt=%d", d.Width, d.Height, (int)d.Format);
        if (d.Width == g_gb[2].desc.Width && d.Height == g_gb[2].desc.Height && CopyOf(g_mask, res, "mask")) g_maskSeq = g_gbSeq;
    }
    Rel(res); Rel(rtv);
}

static void Composite(const float* params, int pass)
{
    if (!Ready()) return;
    ID3D11RenderTargetView* rtv = nullptr;
    ID3D11DepthStencilView* dsv = nullptr;
    g_ctx1->OMGetRenderTargets(1, &rtv, &dsv);
    Rel(dsv);
    if (!rtv) { if (g_logged++ < 3) Log("no render target bound"); return; }

    D3D11_VIEWPORT vp{}; UINT nvp = 1; g_ctx1->RSGetViewports(&nvp, &vp);
    ID3D11Resource* colorRes = nullptr;
    rtv->GetResource(&colorRes);
    // depth comes from an earlier event; by the end of the camera the bound depth is cleared
    bool ok = CopyOf(g_color, colorRes, "color") && g_depth.srv;
    Rel(colorRes);
    // Unity may not have pushed a viewport yet; fall back to the whole target
    if (nvp == 0 || vp.Width < 1 || vp.Height < 1) { vp = {}; vp.Width = (float)g_color.desc.Width; vp.Height = (float)g_color.desc.Height; vp.MaxDepth = 1; }
    static unsigned events[2];
    std::wstring req = g_dir + (pass == 0 ? L"\\capture.req" : L"\\capture1.req");
    bool capture = false;
    if (events[pass] % 30 == 0) capture = GetFileAttributesW(req.c_str()) != INVALID_FILE_ATTRIBUTES;
    if (events[pass]++ == 0)
    {
        D3D11_RENDER_TARGET_VIEW_DESC rd; rtv->GetDesc(&rd);
        Log("pass %d first run vp=%.0f,%.0f %.0fx%.0f rtv fmt=%d ok=%d", pass, vp.TopLeftX, vp.TopLeftY, vp.Width, vp.Height, (int)rd.Format, (int)ok);
    }
    ID3D11PixelShader* ps = ok ? CompilePs(pass) : nullptr;
    UpdateShadowSrv();
    if (ps && g_vs)
    {
        D3D11_MAPPED_SUBRESOURCE m;
        if (SUCCEEDED(g_ctx1->Map(g_cb, 0, D3D11_MAP_WRITE_DISCARD, 0, &m)))
        {
            float* p = (float*)m.pData;
            memcpy(p, params, kParamFloats * 4);
            // slots 15 and 16: target size and viewport, filled here because only the render thread knows them
            p[60] = (float)g_color.desc.Width; p[61] = (float)g_color.desc.Height;
            p[62] = vp.TopLeftX; p[63] = vp.TopLeftY;
            p[64] = vp.Width; p[65] = vp.Height;
            // mask size, or 0 when this frame has no fresh mask (sun without shadows, indoors)
            bool mask = g_mask.srv && g_maskSeq == g_gbSeq;
            p[66] = mask ? (float)g_mask.desc.Width : 0.f; p[67] = mask ? (float)g_mask.desc.Height : 0.f;
            g_ctx1->Unmap(g_cb, 0);
        }
        ID3DDeviceContextState* prev = nullptr;
        g_ctx1->SwapDeviceContextState(g_state, &prev);
        g_ctx1->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
        g_ctx1->VSSetShader(g_vs, nullptr, 0);
        g_ctx1->PSSetShader(ps, nullptr, 0);
        ID3D11ShaderResourceView* srvs[7] = { g_color.srv, g_depth.srv, g_shadowSrv, g_gb[0].srv, g_gb[1].srv, g_gb[2].srv, g_mask.srv };
        g_ctx1->PSSetShaderResources(0, 7, srvs);
        ID3D11SamplerState* ss[2] = { g_sampLinear, g_sampPoint };
        g_ctx1->PSSetSamplers(0, 2, ss);
        g_ctx1->PSSetConstantBuffers(0, 1, &g_cb);
        g_ctx1->RSSetState(g_rs);
        g_ctx1->RSSetViewports(1, &vp);
        g_ctx1->OMSetDepthStencilState(g_dss, 0);
        g_ctx1->OMSetBlendState(g_bs, nullptr, 0xffffffff);
        g_ctx1->OMSetRenderTargets(1, &rtv, nullptr);
        g_ctx1->Draw(3, 0);
        if (capture)
        {
            ID3D11Resource* out = nullptr; rtv->GetResource(&out);
            SaveBmp(g_color.tex, pass == 0 ? L"capture_in.bmp" : L"capture1_in.bmp");
            SaveBmp(out, pass == 0 ? L"capture.bmp" : L"capture1.bmp");
            Rel(out);
            DeleteFileW(req.c_str());
            Log("captured pass %d", pass);
        }
        ID3D11ShaderResourceView* none[7] = {};
        g_ctx1->PSSetShaderResources(0, 7, none);
        g_ctx1->OMSetRenderTargets(0, nullptr, nullptr);
        g_ctx1->SwapDeviceContextState(prev, nullptr);
        Rel(prev);
    }
    Rel(rtv);
}

// GPU time of all plugin work in a frame. Results are read a few frames later, so the CPU never waits on the GPU.
struct GpuFrame { ID3D11Query* dis = nullptr; ID3D11Query* ts[16] = {}; int n = 0; bool open = false, pending = false; };
static GpuFrame g_gf[4];
static int g_gfi;
static double g_gpuSum;
static int g_gpuN;
static float g_gpuMs = -1.f;

static ID3D11Query* MakeQuery(D3D11_QUERY type)
{
    D3D11_QUERY_DESC d{ type, 0 };
    ID3D11Query* q = nullptr;
    g_dev->CreateQuery(&d, &q);
    return q;
}

static void GpuCollect(GpuFrame& f)
{
    if (!f.pending) return;
    f.pending = false;
    D3D11_QUERY_DATA_TIMESTAMP_DISJOINT dj;
    if (g_ctx1->GetData(f.dis, &dj, sizeof dj, D3D11_ASYNC_GETDATA_DONOTFLUSH) != S_OK || dj.Disjoint) return;
    UINT64 sum = 0;
    for (int i = 0; i + 1 < f.n; i += 2)
    {
        UINT64 a, b;
        if (g_ctx1->GetData(f.ts[i], &a, 8, D3D11_ASYNC_GETDATA_DONOTFLUSH) != S_OK) return;
        if (g_ctx1->GetData(f.ts[i + 1], &b, 8, D3D11_ASYNC_GETDATA_DONOTFLUSH) != S_OK) return;
        sum += b - a;
    }
    g_gpuSum += sum * 1000.0 / (double)dj.Frequency;
    if (++g_gpuN == 120) { g_gpuMs = (float)(g_gpuSum / g_gpuN); g_gpuSum = 0; g_gpuN = 0; }
}

static void GpuMark()
{
    if (!g_ready) return;
    GpuFrame* f = &g_gf[g_gfi];
    if (!f->open)
    {
        g_gfi = (g_gfi + 1) % 4;
        f = &g_gf[g_gfi];
        GpuCollect(*f);
        if (!f->dis) { f->dis = MakeQuery(D3D11_QUERY_TIMESTAMP_DISJOINT); for (auto& q : f->ts) q = MakeQuery(D3D11_QUERY_TIMESTAMP); }
        if (!f->dis) return;
        f->n = 0; f->open = true;
        g_ctx1->Begin(f->dis);
    }
    if (f->n < 16 && f->ts[f->n]) g_ctx1->End(f->ts[f->n++]);
}

static void GpuEndFrame()
{
    GpuFrame& f = g_gf[g_gfi];
    if (!f.open) return;
    if (f.n & 1) f.n--;
    g_ctx1->End(f.dis);
    f.open = false; f.pending = true;
}

static void __stdcall OnEvent(int id, void* data)
{
    static bool dead;
    if (dead || !data) return;
    __try
    {
        GpuMark();
        if (id == 2) SaveDepth(); else if (id == 3) SaveGBuffer((const float*)data); else if (id == 5) SaveMask(); else if (id == 1) Composite((const float*)data, 0); else if (id == 4) Composite((const float*)data, 1);
        GpuMark();
        // the final pass is the last plugin work in a frame
        if (id == 1) GpuEndFrame();
    }
    __except (EXCEPTION_EXECUTE_HANDLER) { dead = true; g_faultCode = GetExceptionCode(); Log("fault 0x%08x, pass disabled", (unsigned)g_faultCode); }
}

EXPORT void LP_Init(const wchar_t* dir) { g_dir = dir; Log("loaded"); }
EXPORT void LP_SetShadow(void* tex) { g_shadowPtr = tex; }
EXPORT void* LP_EventFunc() { return (void*)&OnEvent; }
EXPORT int LP_ParamFloats() { return kParamFloats; }
EXPORT unsigned LP_Fault() { return g_faultCode; }
EXPORT float LP_GpuMs() { return g_gpuMs; }
