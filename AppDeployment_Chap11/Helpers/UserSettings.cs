using System.Text.Json;

namespace AppDeployment_Chap11.Helpers
{
    public class UserSettings
    {
        public string Culture { get; set; }

        private static readonly string FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "QuanLySanPham", "usersettings.json");

        public static UserSettings Load()
        {
            try
            {
                if (File.Exists(FilePath))
                    return JsonSerializer.Deserialize<UserSettings>(File.ReadAllText(FilePath))
                           ?? new UserSettings();
            }
            catch
            {
            }
            return new UserSettings();
        }

        public void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
            File.WriteAllText(FilePath,
                JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}