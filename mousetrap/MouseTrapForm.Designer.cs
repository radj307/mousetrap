namespace MouseTrap
{
    partial class MouseTrapForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.cb_Unlock = new System.Windows.Forms.Button();
            this.cb_Lock = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmi_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.LockTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_Interval = new System.Windows.Forms.Panel();
            this.label_NumUpDown = new System.Windows.Forms.Label();
            this.num_Interval = new System.Windows.Forms.NumericUpDown();
            this.img_LockState = new System.Windows.Forms.PictureBox();
            this.cmb_TargetScreen = new System.Windows.Forms.ComboBox();
            this.screenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_TargetScreen = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_buttons.SuspendLayout();
            this.TrayContextMenu.SuspendLayout();
            this.panel_Interval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_LockState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenBindingSource)).BeginInit();
            this.panel_TargetScreen.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_buttons
            // 
            this.panel_buttons.BackColor = System.Drawing.SystemColors.Control;
            this.panel_buttons.CausesValidation = false;
            this.panel_buttons.Controls.Add(this.cb_Unlock);
            this.panel_buttons.Controls.Add(this.cb_Lock);
            this.panel_buttons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_buttons.Location = new System.Drawing.Point(81, 8);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(162, 30);
            this.panel_buttons.TabIndex = 0;
            // 
            // cb_Unlock
            // 
            this.cb_Unlock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_Unlock.Location = new System.Drawing.Point(84, 3);
            this.cb_Unlock.Name = "cb_Unlock";
            this.cb_Unlock.Size = new System.Drawing.Size(75, 24);
            this.cb_Unlock.TabIndex = 2;
            this.cb_Unlock.Text = "Unlock";
            this.cb_Unlock.UseMnemonic = false;
            this.cb_Unlock.UseVisualStyleBackColor = true;
            this.cb_Unlock.Click += new System.EventHandler(this.cb_Unlock_Click);
            // 
            // cb_Lock
            // 
            this.cb_Lock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_Lock.Location = new System.Drawing.Point(3, 3);
            this.cb_Lock.Name = "cb_Lock";
            this.cb_Lock.Size = new System.Drawing.Size(75, 24);
            this.cb_Lock.TabIndex = 1;
            this.cb_Lock.Text = "Lock";
            this.cb_Lock.UseMnemonic = false;
            this.cb_Lock.UseVisualStyleBackColor = true;
            this.cb_Lock.Click += new System.EventHandler(this.cb_Lock_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayContextMenu;
            this.TrayIcon.Text = "Mouse Trap";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // TrayContextMenu
            // 
            this.TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmi_Close});
            this.TrayContextMenu.Name = "TrayContextMenu";
            this.TrayContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // csmi_Close
            // 
            this.csmi_Close.Name = "csmi_Close";
            this.csmi_Close.Size = new System.Drawing.Size(103, 22);
            this.csmi_Close.Text = "Close";
            this.csmi_Close.Click += new System.EventHandler(this.csmi_Close_Click);
            // 
            // LockTimer
            // 
            this.LockTimer.Interval = 1;
            this.LockTimer.Tick += new System.EventHandler(this.LockTimer_Tick);
            // 
            // panel_Interval
            // 
            this.panel_Interval.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Interval.Controls.Add(this.label_NumUpDown);
            this.panel_Interval.Controls.Add(this.num_Interval);
            this.panel_Interval.Location = new System.Drawing.Point(81, 42);
            this.panel_Interval.Name = "panel_Interval";
            this.panel_Interval.Size = new System.Drawing.Size(162, 30);
            this.panel_Interval.TabIndex = 1;
            // 
            // label_NumUpDown
            // 
            this.label_NumUpDown.AutoSize = true;
            this.label_NumUpDown.BackColor = System.Drawing.Color.Transparent;
            this.label_NumUpDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_NumUpDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumUpDown.Location = new System.Drawing.Point(5, 5);
            this.label_NumUpDown.Name = "label_NumUpDown";
            this.label_NumUpDown.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.label_NumUpDown.Size = new System.Drawing.Size(73, 20);
            this.label_NumUpDown.TabIndex = 1;
            this.label_NumUpDown.Text = "Interval (ms)";
            this.label_NumUpDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Interval
            // 
            this.num_Interval.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_Interval.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num_Interval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Interval.Location = new System.Drawing.Point(84, 3);
            this.num_Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Interval.Name = "num_Interval";
            this.num_Interval.Size = new System.Drawing.Size(75, 23);
            this.num_Interval.TabIndex = 0;
            this.num_Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Interval.ValueChanged += new System.EventHandler(this.Interval_ValueChanged);
            // 
            // img_LockState
            // 
            this.img_LockState.BackColor = System.Drawing.Color.Transparent;
            this.img_LockState.Image = global::MouseTrap.Properties.Resources.locked_64;
            this.img_LockState.Location = new System.Drawing.Point(8, 8);
            this.img_LockState.Name = "img_LockState";
            this.img_LockState.Size = new System.Drawing.Size(64, 64);
            this.img_LockState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_LockState.TabIndex = 2;
            this.img_LockState.TabStop = false;
            // 
            // cmb_TargetScreen
            // 
            this.cmb_TargetScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_TargetScreen.DataSource = this.screenBindingSource;
            this.cmb_TargetScreen.DisplayMember = "ScreenName";
            this.cmb_TargetScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TargetScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_TargetScreen.FormattingEnabled = true;
            this.cmb_TargetScreen.Location = new System.Drawing.Point(3, 3);
            this.cmb_TargetScreen.Name = "cmb_TargetScreen";
            this.cmb_TargetScreen.Size = new System.Drawing.Size(229, 23);
            this.cmb_TargetScreen.TabIndex = 3;
            this.cmb_TargetScreen.SelectedIndexChanged += new System.EventHandler(this.cmb_TargetScreen_SelectedIndexChanged);
            // 
            // screenBindingSource
            // 
            this.screenBindingSource.AllowNew = true;
            this.screenBindingSource.DataSource = typeof(MouseTrap.ScreenWrapperList);
            // 
            // panel_TargetScreen
            // 
            this.panel_TargetScreen.BackColor = System.Drawing.SystemColors.Control;
            this.panel_TargetScreen.Controls.Add(this.cmb_TargetScreen);
            this.panel_TargetScreen.Location = new System.Drawing.Point(8, 78);
            this.panel_TargetScreen.Name = "panel_TargetScreen";
            this.panel_TargetScreen.Size = new System.Drawing.Size(235, 29);
            this.panel_TargetScreen.TabIndex = 4;
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_Main.Controls.Add(this.img_LockState);
            this.panel_Main.Controls.Add(this.panel_buttons);
            this.panel_Main.Controls.Add(this.panel_TargetScreen);
            this.panel_Main.Controls.Add(this.panel_Interval);
            this.panel_Main.ForeColor = System.Drawing.Color.Transparent;
            this.panel_Main.Location = new System.Drawing.Point(1, 1);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Main.Size = new System.Drawing.Size(251, 115);
            this.panel_Main.TabIndex = 5;
            // 
            // MouseTrapForm
            // 
            this.AcceptButton = this.cb_Lock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.CancelButton = this.cb_Unlock;
            this.ClientSize = new System.Drawing.Size(253, 117);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MouseTrapForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mouse Trap";
            this.TopMost = true;
            this.panel_buttons.ResumeLayout(false);
            this.TrayContextMenu.ResumeLayout(false);
            this.panel_Interval.ResumeLayout(false);
            this.panel_Interval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_LockState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenBindingSource)).EndInit();
            this.panel_TargetScreen.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_buttons;
        private Button cb_Unlock;
        private Button cb_Lock;
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayContextMenu;
        private ToolStripMenuItem csmi_Close;
        private System.Windows.Forms.Timer LockTimer;
        private Panel panel_Interval;
        private Label label_NumUpDown;
        private NumericUpDown num_Interval;
        private PictureBox img_LockState;
        private ComboBox cmb_TargetScreen;
        private Panel panel_TargetScreen;
        private BindingSource screenBindingSource;
        private Panel panel_Main;
    }
}