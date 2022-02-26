namespace MouseTrap
{
    public partial class MouseTrap : Form
    {
        private Rectangle bounds = new();
        private Point max = new();

        private readonly Color colLocked = Color.FromArgb(255, 255, 8, 2), colUnlocked = Color.FromArgb(255, 15, 255, 0);
        private readonly Image locked = Properties.Resources.locked_64, unlocked = Properties.Resources.unlocked_64;

        private ScreenWrapperList screens;

        private void UpdateStateImage()
        {
            if (LockerEnabled)
            {
                BackColor = colLocked;
                img_LockState.Image = locked;
            }
            else
            {
                BackColor = colUnlocked;
                img_LockState.Image = unlocked;
            }
        }

        public bool LockerEnabled
        {
            get => Properties.Settings.Default.LockEnabled;
            set
            {
                if (value)
                {
                    LockTimer.Enabled = Properties.Settings.Default.LockEnabled = true;
                    UpdateStateImage();
                }
                else
                {
                    LockTimer.Enabled = Properties.Settings.Default.LockEnabled = false;
                    UpdateStateImage();
                }
            }
        }

        public MouseTrap()
        {
            InitializeComponent();

            bounds = Screen.PrimaryScreen.Bounds;

            max.X = bounds.X + bounds.Width;
            max.Y = bounds.Y + bounds.Height;

            num_Interval.Value = Convert.ToDecimal(LockTimer.Interval = Properties.Settings.Default.CheckInterval);

            LockerEnabled = false;

            screens = new ScreenWrapperList();
            screenBindingSource.DataSource = screens;
        }

        private void csmi_Close_Click(object sender, EventArgs e) => Close();

        private void cb_Lock_Click(object sender, EventArgs e) => LockerEnabled = true;

        private void cb_Unlock_Click(object sender, EventArgs e) => LockerEnabled = false;

        private void Interval_ValueChanged(object sender, EventArgs e)
        {
            LockTimer.Interval = Properties.Settings.Default.CheckInterval = Convert.ToInt32(num_Interval.Value);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) => Show();

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            Point current = MousePosition;
            if (!bounds.Contains(current))
            {
                if (current.X < bounds.X)
                    current.X = bounds.X;
                else if (current.X >= max.X)
                    current.X = max.X;

                if (current.Y < bounds.Y)
                    current.Y = bounds.Y;
                else if (current.Y >= max.Y)
                    current.Y = max.Y;

                Cursor.Position = current;
            }
        }
    }
}