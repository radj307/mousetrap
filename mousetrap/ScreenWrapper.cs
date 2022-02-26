namespace MouseTrap
{
    public class ScreenWrapper : IScreen
    {
        private readonly Screen _screen;
        private readonly string _name;

        public ScreenWrapper(Screen scr, string? name = null)
        {
            _screen = scr;
            _name = name ?? _screen.ScreenName();
        }

        public Screen Screen { get => _screen; }
        public string ScreenName { get => _name; }
    }
}
