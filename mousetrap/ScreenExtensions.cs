namespace MouseTrap
{
    public static class ScreenExtensions
    {
        public static string ScreenName(this Screen scr)
            => $"{scr.DeviceName.Match(new("[a-zA-Z0-9]+", System.Text.RegularExpressions.RegexOptions.Compiled))}";
    }
}
