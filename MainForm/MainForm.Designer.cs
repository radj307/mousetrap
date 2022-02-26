namespace MainForm
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_NumUpDown = new System.Windows.Forms.Label();
            this.num_Interval = new System.Windows.Forms.NumericUpDown();
            this.panel_buttons.SuspendLayout();
            this.TrayContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_buttons
            // 
            this.panel_buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_buttons.CausesValidation = false;
            this.panel_buttons.Controls.Add(this.cb_Unlock);
            this.panel_buttons.Controls.Add(this.cb_Lock);
            this.panel_buttons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_buttons.Location = new System.Drawing.Point(1, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(163, 32);
            this.panel_buttons.TabIndex = 0;
            // 
            // cb_Unlock
            // 
            this.cb_Unlock.Location = new System.Drawing.Point(84, 3);
            this.cb_Unlock.Name = "cb_Unlock";
            this.cb_Unlock.Size = new System.Drawing.Size(75, 25);
            this.cb_Unlock.TabIndex = 1;
            this.cb_Unlock.Text = "Unlock";
            this.cb_Unlock.UseMnemonic = false;
            this.cb_Unlock.UseVisualStyleBackColor = true;
            this.cb_Unlock.Click += new System.EventHandler(this.cb_Unlock_Click);
            // 
            // cb_Lock
            // 
            this.cb_Lock.Location = new System.Drawing.Point(3, 3);
            this.cb_Lock.Name = "cb_Lock";
            this.cb_Lock.Size = new System.Drawing.Size(75, 25);
            this.cb_Lock.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_NumUpDown);
            this.panel1.Controls.Add(this.num_Interval);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 23);
            this.panel1.TabIndex = 1;
            // 
            // label_NumUpDown
            // 
            this.label_NumUpDown.AutoSize = true;
            this.label_NumUpDown.Location = new System.Drawing.Point(3, 0);
            this.label_NumUpDown.Name = "label_NumUpDown";
            this.label_NumUpDown.Size = new System.Drawing.Size(73, 15);
            this.label_NumUpDown.TabIndex = 1;
            this.label_NumUpDown.Text = "Interval (ms)";
            // 
            // num_Interval
            // 
            this.num_Interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_Interval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Interval.Location = new System.Drawing.Point(84, 0);
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
            this.num_Interval.Size = new System.Drawing.Size(78, 19);
            this.num_Interval.TabIndex = 0;
            this.num_Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Interval.ValueChanged += new System.EventHandler(this.Interval_ValueChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.cb_Lock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.cb_Unlock;
            this.ClientSize = new System.Drawing.Size(164, 55);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Mouse Trap";
            this.panel_buttons.ResumeLayout(false);
            this.TrayContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Interval)).EndInit();
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
        private Panel panel1;
        private Label label_NumUpDown;
        private NumericUpDown num_Interval;
    }
}