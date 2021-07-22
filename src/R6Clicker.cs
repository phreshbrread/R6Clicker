using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace R6Clicker
{
    public partial class R6Clicker : Form
    {
        // Declare variables
        public int mouseClickX;
        public int mouseClickY;

        public string ResTextBoxText;

        public R6Clicker()
        {
            InitializeComponent();

            if (File.Exists("settings.ini") == false)
            {
                ClickTimer.Interval = 2000;
                mouseClickX = 1200;
                mouseClickY = 985;

                CustomPosBoxX.Text = Convert.ToString(200);
                CustomPosBoxY.Text = Convert.ToString(200);

                IntervalBox.Text = ClickTimer.Interval.ToString();

                WriteSets();
            }

            // Read each line of the file into a string array.
            // Each element of the array is one line of the file.
            string[] lines = File.ReadAllLines("settings.ini");

            // Set values to those from settings file
            try
            {
                ClickTimer.Interval = Convert.ToInt32(lines[0]); // Set value to Int32 from lines variable
            }
            catch (FormatException)
            {
                File.Delete("settings.ini");
                MessageBox.Show("An error with the settings file was found. Please relaunch the application.", "Settings File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            Int32.TryParse(lines[1], out mouseClickX);
            Int32.TryParse(lines[2], out mouseClickY);

            IntervalBox.Text = ClickTimer.Interval.ToString();

            if (Convert.ToInt32(lines[3]) <= 0 || Convert.ToInt32(lines[4]) <= 0)
            {
                CustomPosBoxX.Text = "200";
                CustomPosBoxY.Text = "200";
            }
            else
            {
                CustomPosBoxX.Text = lines[3];
                CustomPosBoxY.Text = lines[4];
            }

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
        #endregion

        public void SetMousePos(int x, int y) // Set the mouse position based on the MouseClickX and Y variables
        {
            ResTextBoxText = x + ", " + y;

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

            Refresh();

            SetCursorPos(mouseClickX, mouseClickY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseClickX, mouseClickY, 0, 0);
            System.Threading.Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, mouseClickX, mouseClickY, 0, 0);
            System.Threading.Thread.Sleep(50);
        }

        void WriteSets()
        {
            if (Convert.ToInt32(CustomPosBoxX.Text) <= 0 || Convert.ToInt32(CustomPosBoxY.Text) <= 0)
            {
                CustomPosBoxX.Text = "200";
                CustomPosBoxY.Text = "200";
            }

            FileRW.WriteSettings(Convert.ToInt32(IntervalBox.Text), mouseClickX, mouseClickY, Convert.ToInt32(CustomPosBoxX.Text), Convert.ToInt32(CustomPosBoxY.Text));
        }

        #region Button clicks
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Try to convert the contents of the click timer box into an integer, otherwise do nothing.
            Int32.TryParse(IntervalBox.Text, out int interval);
            if (interval > 0)
            {
                ClickTimer.Interval = interval;
                WriteSets();
                ClickTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a value within 0 to 2147483647.", "Input Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClickTimer.Enabled = false;
        }

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