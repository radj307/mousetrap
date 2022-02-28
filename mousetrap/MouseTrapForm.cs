namespace MouseTrap
{
    public partial class MouseTrapForm : Form
    {
        #region Constructor

        public MouseTrapForm()
        {
            InitializeComponent();

            bounds = Screen.PrimaryScreen.Bounds;

            max.X = bounds.X + bounds.Width;
            max.Y = bounds.Y + bounds.Height;

            num_Interval.Value = Convert.ToDecimal(LockTimer.Interval = Properties.Settings.Default.CheckInterval);

            LockerEnabled = false;

            screens = new ScreenWrapperList();
            screenBindingSource.DataSource = screens;

            string name = Properties.Settings.Default.TargetScreen;
            foreach (ScreenWrapper scr in cmb_TargetScreen.Items)
            {
                if (scr.ScreenName == name)
                {
                    cmb_TargetScreen.SelectedItem = scr;
                }
            }

            // set the window title
            Text = $"Mouse Trap v{System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion?.Match(new("([0-9]+\\.[0-9]+\\.[0-9]+)(?:\\.*[1-9])*"))}";
        }

        #endregion Constructor

        #region Members

        private Rectangle bounds = new();
        private Point max = new();
        private bool locked = false;

        private readonly Color colLocked = Color.FromArgb(255, 255, 8, 2), colUnlocked = Color.FromArgb(255, 15, 255, 0);
        private readonly Image imgLocked = Properties.Resources.locked_64, imgUnlocked = Properties.Resources.unlocked_64;

        private readonly ScreenWrapperList screens;

        #endregion Members

        #region Properties

        public bool LockerEnabled
        {
            get => locked;
            set
            {
                LockTimer.Enabled = locked = value;
                UpdateStateImage();
            }
        }

        #endregion Properties

        #region Methods

        private void UpdateTargetScreen(ScreenWrapper? scr)
        {
            if (scr == null)
                return;

            bool enabled = LockerEnabled;
            cb_Unlock_Click(this, EventArgs.Empty);

            bounds = scr.Screen.Bounds;

            max.X = bounds.X + bounds.Width;
            max.Y = bounds.Y + bounds.Height;

            Properties.Settings.Default.TargetScreen = scr.ScreenName;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            if (enabled) cb_Lock_Click(this, EventArgs.Empty);
        }

        private void UpdateStateImage()
        {
            if (LockerEnabled)
            {
                BackColor = colLocked;
                img_LockState.Image = imgLocked;
            }
            else
            {
                BackColor = colUnlocked;
                img_LockState.Image = imgUnlocked;
            }
        }

        #endregion Methods

        #region FormMethods

        private void csmi_Close_Click(object sender, EventArgs e) => Close();

        private void cb_Lock_Click(object sender, EventArgs e) => LockerEnabled = true;

        private void cb_Unlock_Click(object sender, EventArgs e) => LockerEnabled = false;

        private void Interval_ValueChanged(object sender, EventArgs e)
        {
            LockTimer.Interval = Properties.Settings.Default.CheckInterval = Convert.ToInt32(num_Interval.Value);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void cmb_TargetScreen_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateTargetScreen((ScreenWrapper)cmb_TargetScreen.SelectedItem);

        private void TrayIcon_DoubleClick(object sender, EventArgs e) => Show();

        private void csmi_Lock_CheckedChanged(object sender, EventArgs e)
            => LockerEnabled = csmi_Lock.Checked;

        private void csmi_BringToFront_Click(object sender, EventArgs e)
            => BringToFront();

        private void csmi_AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysOnTop = TopMost = csmi_AlwaysOnTop.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

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

        #endregion FormMethods
    }
}