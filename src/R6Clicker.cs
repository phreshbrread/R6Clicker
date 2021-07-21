using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace R6Clicker
{
    public partial class R6Clicker : Form
    {
        // Declare variables
        public int mouseClickX = 1200;
        public int mouseClickY = 985;

        public string ResTextBoxText;

        public R6Clicker()
        {
            InitializeComponent();

            IntervalBox.Text = ClickTimer.Interval.ToString();

            SetMousePos(mouseClickX, mouseClickY);
        }

        #region Import DLLs and stuff
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        // Declare some keyboard keys as constants with its respective code
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_RETURN = 0x0D; //Enter key code

        #endregion

        public void SetMousePos(int x, int y) // Set the mouse position based on the MouseClickX and Y variables
        {
            ResTextBoxText = x + " x " + y;

            mouseClickX = x;
            mouseClickY = y;

            ResolutionTextBox.Text = ResTextBoxText;
        }

        private void ClickTimer_Tick(object sender, EventArgs e) // Run every time the timer ticks.
        {
            
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("RainbowSix"); // Search for R6 process
            if (p.Length > 0) // Check if window was found
            {
                SetForegroundWindow(p[0].MainWindowHandle); // Bring Siege to foreground
            }
            System.Diagnostics.Debug.WriteLine(p.Length.ToString());

            SetCursorPos(mouseClickX, mouseClickY);
            Refresh();
            
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseClickX, mouseClickY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, mouseClickX, mouseClickY, 0, 0);
        }

        #region Button clicks
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Try to convert the contents of the click timer box into an integer, otherwise do nothing.
            Int32.TryParse(IntervalBox.Text, out int interval);
            if(interval > 0)
            {
                ClickTimer.Interval = interval;
                ClickTimer.Enabled = true;
            } else
            {
                MessageBox.Show("Please enter a value above 0", "Input Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClickTimer.Enabled = false;
        }

        // TODO Fix 1440 & 768
        private void Res4k_Click(object sender, EventArgs e)
        {
            mouseClickX = 2400;
            mouseClickY = 1980;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void Res1440p_Click(object sender, EventArgs e)
        {
            mouseClickX = 1600;
            mouseClickY = 1325;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void Res1080p_Click(object sender, EventArgs e)
        {
            mouseClickX = 1200;
            mouseClickY = 985;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void Res768p_Click(object sender, EventArgs e)
        {
            mouseClickX = 900;
            mouseClickY = 690;

            SetMousePos(mouseClickX, mouseClickY);
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                mouseClickX = Convert.ToInt32(CustomPosBoxX.Text);
                mouseClickY = Convert.ToInt32(CustomPosBoxY.Text);
            }
            catch (FormatException) { }

            SetMousePos(mouseClickX, mouseClickY);
        }
        #endregion
    }
}