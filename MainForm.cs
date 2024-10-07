#region using

using ArkaneSystems.MouseJiggler.Properties;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace ArkaneSystems.MouseJiggler
{
    public partial class MainForm : Form
    {
        // Importing user32.dll for mouse and keyboard simulation
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        // Constants for mouse events
        private const int MOUSEEVENTF_WHEEL = 0x0800;

        // Constants for key events
        private const uint KEYEVENTF_KEYDOWN = 0x0000;
        private const uint KEYEVENTF_KEYUP = 0x0002;

        // Key codes for Left Ctrl, Left Alt, and Arrow keys
        private readonly byte[] keysToPress = { 0xA2, 0xA4, 0x26, 0x28, 0x25, 0x27 }; // Left Ctrl, Left Alt, Up, Down, Left, Right

        private Random random = new Random();

        /// <summary>
        /// Constructor for use by the form designer.
        /// </summary>
        public MainForm()
            : this(jiggleOnStartup: false, minimizeOnStartup: false, zenJiggleEnabled: false, jigglePeriod: 1)
        { }

        public MainForm(bool jiggleOnStartup, bool minimizeOnStartup, bool zenJiggleEnabled, int jigglePeriod)
        {
            this.InitializeComponent();

            // Set some default values
            this.cbMinimize.Checked = true;
            this.cbZen.Checked = false;
            this.cbJiggling.Checked = true;
            this.tbPeriod.Value = 4;

            this.panelSettings.Visible = true;
        }

        public bool JiggleOnStartup { get; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.JiggleOnStartup)
                this.cbJiggling.Checked = false;
        }

        private void UpdateNotificationAreaText()
        {
            if (!this.cbJiggling.Checked)
            {
                this.niTray.Text = "Not jiggling the mouse.";
            }
            else
            {
                string? ww = this.ZenJiggleEnabled ? "with" : "without";
                this.niTray.Text = $"Jiggling mouse every {this.JigglePeriod} s, {ww} Zen.";
            }
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(owner: this);
        }

        #region Property synchronization

        private void cbSettings_CheckedChanged(object sender, EventArgs e)
        {
            this.panelSettings.Visible = this.cbSettings.Checked;
        }

        private void cbMinimize_CheckedChanged(object sender, EventArgs e)
        {
            this.MinimizeOnStartup = this.cbMinimize.Checked;
        }

        private void cbZen_CheckedChanged(object sender, EventArgs e)
        {
            this.ZenJiggleEnabled = this.cbZen.Checked;
        }

        private void tbPeriod_ValueChanged(object sender, EventArgs e)
        {
            this.JigglePeriod = this.tbPeriod.Value;
        }

        #endregion Property synchronization

        #region Do the Jiggle and Scroll/Key Press

        protected bool Zig = true;

        private void cbJiggling_CheckedChanged(object sender, EventArgs e)
        {
            this.jiggleTimer.Enabled = this.cbJiggling.Checked;
        }

        private void jiggleTimer_Tick(object sender, EventArgs e)
        {
            // Mouse jiggle
            if (this.ZenJiggleEnabled)
                Helpers.Jiggle(delta: 4);
            else if (this.Zig)
                Helpers.Jiggle(delta: 4);
            else //zag
                Helpers.Jiggle(delta: -4);

            this.Zig = !this.Zig;

            if (this.cbScroll.Checked)
            {
                if (this.Zig)
                    mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 120, 0); // Scroll up
                else //zag
                    mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -120, 0); // Scroll down

            }

            if (this.cbKeys.Checked)
            {
                byte randomKey = keysToPress[random.Next(keysToPress.Length)];

                keybd_event(randomKey, 0, KEYEVENTF_KEYDOWN, 0); // Key down
                keybd_event(randomKey, 0, KEYEVENTF_KEYUP, 0);   // Key up
            }
            
        }

        #endregion Do the Jiggle and Scroll/Key Press

        #region Minimize and restore

        private void cmdTrayify_Click(object sender, EventArgs e)
        {
            this.MinimizeToTray();
        }

        private void niTray_DoubleClick(object sender, EventArgs e)
        {
            this.RestoreFromTray();
        }

        private void MinimizeToTray()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.niTray.Visible = true;

            this.UpdateNotificationAreaText();
        }

        private void RestoreFromTray()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.niTray.Visible = false;
        }

        #endregion Minimize and restore

        #region Settings property backing fields

        private int jigglePeriod;

        private bool minimizeOnStartup;

        private bool zenJiggleEnabled;

        #endregion Settings property backing fields

        #region Settings properties

        public bool MinimizeOnStartup
        {
            get => this.minimizeOnStartup;
            set
            {
                this.minimizeOnStartup = value;
                Settings.Default.MinimizeOnStartup = value;
                Settings.Default.Save();
            }
        }

        public bool ZenJiggleEnabled
        {
            get => this.zenJiggleEnabled;
            set
            {
                this.zenJiggleEnabled = value;
                Settings.Default.ZenJiggle = value;
                Settings.Default.Save();
            }
        }

        public int JigglePeriod
        {
            get => this.jigglePeriod;
            set
            {
                this.jigglePeriod = value;
                Settings.Default.JigglePeriod = value;
                Settings.Default.Save();

                this.jiggleTimer.Interval = value * 1000;
                this.lbPeriod.Text = $"{value} s";
            }
        }

        #endregion Settings properties
        private bool firstShown = true;
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (this.firstShown && this.MinimizeOnStartup)
                this.MinimizeToTray();

            this.firstShown = false;
        }
    }
}
