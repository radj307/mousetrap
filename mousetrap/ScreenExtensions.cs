namespace MouseTrap
{
    public static class ScreenExtensions
    {
        public static string ScreenName(this Screen scr)
            => $"{scr.DeviceName.Match(new("[a-zA-Z]+", System.Text.RegularExpressions.RegexOptions.Compiled))}";
    }
}
