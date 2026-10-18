namespace AppDeployment_Chap11.Helpers
{
 
    public class AppSettings
    {
        // API tỷ giá fawazahmed0/exchange-api: URL chính (CDN jsDelivr) + URL dự phòng (Cloudflare Pages)
        public string ApiPrimaryUrl { get; set; } = "https://cdn.jsdelivr.net/npm/@fawazahmed0/currency-api@latest/v1/";
        public string ApiFallbackUrl { get; set; } = "https://latest.currency-api.pages.dev/v1/";

        public string DefaultCulture { get; set; } = "vi-VN";
        public string LogFolder { get; set; } = "Logs";
    }
}
