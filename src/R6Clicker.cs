using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using R6Clicker.src;

namespace R6Clicker
{
    public partial class R6Clicker : Form
    {
        public int mouseClickX = 860;
        public int mouseClickY = 960;
        
        public R6Clicker()
        {
            // window size should be 1267, 560
            InitializeComponent();

            IntervalBox.Text = ClickTimer.Interval.ToString();
            ResolutionTextBox.Text = "1920x1080";
        }

        #region Import DLLs and stuff
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        #endregion

        private void StartButton_Click(object sender, EventArgs e)
        {
            ClickTimer.Interval = Convert.ToInt32(IntervalBox.Text);
            ClickTimer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClickTimer.Enabled = false;
        }

        #region Resolution button clicks
        private void Res4k_Click(object sender, EventArgs e)
        {
            ResolutionTextBox.Text = "3840x2160";

            mouseClickX = 1675;
            mouseClickY = 1940;
        }

        private void Res1440p_Click(object sender, EventArgs e)
        {
            ResolutionTextBox.Text = "2560x1440";

            mouseClickX = 1120;
            mouseClickY = 1290;
        }

        private void Res1080p_Click(object sender, EventArgs e)
        {
            ResolutionTextBox.Text = "1920x1080";

            mouseClickX = 860;
            mouseClickY = 960;
        }

        private void Res768p_Click(object sender, EventArgs e)
        {
            ResolutionTextBox.Text = "1366x768";

            mouseClickX = 595;
            mouseClickY = 690;
        }
#endregion

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            SetCursorPos(mouseClickX, mouseClickY);
            Refresh();
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseClickX, mouseClickY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, mouseClickX, mouseClickY, 0, 0);
        }

        private void CustomResButton_Click(object sender, EventArgs e)
        {
            CustomResolutionForm customResolution = new CustomResolutionForm();
            customResolution.Show();
        }
    }
}