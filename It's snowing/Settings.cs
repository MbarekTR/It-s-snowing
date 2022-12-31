namespace It_s_snowing
{
    internal class Settings
    {
        private static readonly string[] _settingsName = { "SnowThickness", "LoadSnow", "Language" };

        public static bool SnowThickness { get; } = Properties.Settings.Default.SnowThickness;
        public static bool LoadSnow { get; } = Properties.Settings.Default.LoadSnow;
        public static bool Language { get; } = Properties.Settings.Default.Language;

        public static void SaveSettings(byte settingsName, bool settingsValue)
        {
            Properties.Settings.Default[_settingsName[settingsName]] = settingsValue;
            Properties.Settings.Default.Save();
        }
    }
}
