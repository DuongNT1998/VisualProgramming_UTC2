using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Threading.Tasks;
using AppDeployment_Chap11.Helpers;
using Serilog;

namespace AppDeployment_Chap11.Services
{
    public static class TyGiaService
    {
        private static readonly HttpClient _http = new HttpClient
        {
            Timeout = System.TimeSpan.FromSeconds(10)
        };

        public static async Task<decimal> LayTyGiaAsync(string ngoaiTe)
        {
            string code = ngoaiTe.ToLowerInvariant();

            string[] danhSachUrl =
            {
                AppConfig.Settings.ApiPrimaryUrl,
                AppConfig.Settings.ApiFallbackUrl
            };

            System.Exception loiCuoi = null;

            foreach (string baseUrl in danhSachUrl)
            {
                if (string.IsNullOrWhiteSpace(baseUrl)) continue;

                string url = $"{baseUrl.TrimEnd('/')}/currencies/{code}.json";
                try
                {
                    decimal tyGia = await LayTuUrlAsync(url, code);
                    Log.Information("Lấy tỷ giá {NgoaiTe}->VND = {TyGia} từ {Url}", ngoaiTe, tyGia, url);
                    return tyGia;
                }
                catch (System.Exception ex) when (
                    ex is HttpRequestException or TaskCanceledException or
                    JsonException or KeyNotFoundException)
                {
                    Log.Warning(ex, "Gọi {Url} thất bại, thử URL dự phòng (nếu còn)...", url);
                    loiCuoi = ex;
                }
            }

            if (loiCuoi != null) ExceptionDispatchInfo.Capture(loiCuoi).Throw();
            throw new System.InvalidOperationException("Chưa cấu hình URL API tỷ giá trong appsettings.json.");
        }

        private static async Task<decimal> LayTuUrlAsync(string url, string code)
        {
            using HttpResponseMessage resp = await _http.GetAsync(url);
            resp.EnsureSuccessStatusCode();

            string json = await resp.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(json);

            return doc.RootElement
                .GetProperty(code)
                .GetProperty("vnd")
                .GetDecimal();
        }
    }
}