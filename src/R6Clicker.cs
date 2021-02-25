using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using R6Clicker;

namespace R6Clicker
{
    public partial class R6Clicker : Form
    {
        // Declare variables
        public int mouseClickX = 860;
        public int mouseClickY = 960;

        public string ResTextBoxText;
        
        public R6Clicker()
        {
            InitializeComponent();

            IntervalBox.Text = ClickTimer.Interval.ToString();

            SetMousePos(mouseClickX, mouseClickY);
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
            try // Try to convert the contents of the click timer box into an integer, otherwise do nothing rather than throwing an exception.
            {
                ClickTimer.Interval = Convert.ToInt32(IntervalBox.Text);
            }
            catch (FormatException) { }
            
            ClickTimer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClickTimer.Enabled = false;
        }

        #region Resolution button clicks
        private void Res4k_Click(object sender, EventArgs e)
        {
            mouseClickX = 1675;
            mouseClickY = 1940;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void Res1440p_Click(object sender, EventArgs e)
        {
            mouseClickX = 1120;
            mouseClickY = 1290;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void Res1080p_Click(object sender, EventArgs e)
        {
            mouseClickX = 860;
            mouseClickY = 960;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void Res768p_Click(object sender, EventArgs e)
        {
            mouseClickX = 595;
            mouseClickY = 690;

            SetMousePos(mouseClickX, mouseClickY);
        }
#endregion

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            SetCursorPos(mouseClickX, mouseClickY);
            Refresh();
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseClickX, mouseClickY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, mouseClickX, mouseClickY, 0, 0);
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                mouseClickX = Convert.ToInt32(CustomPosBoxX.Text);
                mouseClickY = Convert.ToInt32(CustomPosBoxY.Text);
            }
            catch (FormatException)
            {

            }

            SetMousePos(mouseClickX, mouseClickY);
        }

        public void SetMousePos(int x, int y) // Set the mouse position based on the MouseClickX and Y variables
        {
            ResTextBoxText = x + " x " + y;

            mouseClickX = x;
            mouseClickY = y;

            ResolutionTextBox.Text = ResTextBoxText;
        }
    }
}