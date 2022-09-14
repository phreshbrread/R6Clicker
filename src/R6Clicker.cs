using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace R6Clicker
{
    public partial class R6Clicker : Form
    {
        // Declare variables
        public int mouseClickX;
        public int mouseClickY;

        public string MousePosTextBoxText;

        #region Help Message
        private string helpMessage = "1. Set Training Grounds matchmaking preferences to PROTECT HOSTAGE ONLY. \n" +
            "2. Also set MM preferences to big maps only, I recommend just leaving it only on Fortress. \n" +
            "3. Load into a solo training grounds match on easy mode and start the clicker. \n" +
            "4. You should eventually die and fail but still recieve some renown bonus, the clicker automatically hits the restart button so the process repeats itself. \n" +
            "\n" +
            "More info can be found on the GitHub page.";
        #endregion

        #region DLL stuff
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        // Import the RegisterHotKey Method
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        #endregion

        public R6Clicker()
        {
            InitializeComponent();

            // If the settings file doesn't exist then make one
            if (!File.Exists("settings.ini"))
            {
                ClickTimer.Interval = 2000;
                mouseClickX = 1320;
                mouseClickY = 990;

                CustomPosBoxX.Text = Convert.ToString(200);
                CustomPosBoxY.Text = Convert.ToString(200);

                IntervalBox.Text = ClickTimer.Interval.ToString();

                WriteSettings();
            }

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

            // 3. Register Hotkey
            // Set an unique id to your Hotkey, it will be used to
            // identify which hotkey was pressed in your code to execute something
            int UniqueHotkeyId = 1;
            int HotKeyCode = (int)Keys.F9;
            // Register the "F9" hotkey
            bool F9Registered = RegisterHotKey(
                this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode
            );
            // Repeat the same process but with F10
            int SecondHotkeyId = 2;
            int SecondHotKeyKey = (int)Keys.F10;
            bool F10Registered = RegisterHotKey(
                this.Handle, SecondHotkeyId, 0x0000, SecondHotKeyKey
            );

            SetMousePos(mouseClickX, mouseClickY);
        }

        protected override void WndProc(ref Message m)
        {
            // Catch when a HotKey is pressed
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                // Handle what will happen once a respective hotkey is pressed
                switch (id)
                {
                    case 1:
                        StartButton_Click(null, null);
                        break;
                    case 2:
                        StopButton_Click(null, null);
                        break;
                }
            }

            base.WndProc(ref m);
        }

        public void SetMousePos(int x, int y) // Set the mouse position based on the MouseClickX and Y variables
        {
            mouseClickX = x;
            mouseClickY = y;

            MousePosTextBox.Text = x + ", " + y;
        }

        public static void RelativeMove(int relx, int rely)
        {
            mouse_event(0x0001, relx, rely, 0, 0); // Move the mouse slightly so the game accepts input
        }

        private void ClickTimer_Tick(object sender, EventArgs e) // Run every time the timer ticks.
        {
            Process[] p = Process.GetProcessesByName("RainbowSix"); // Search for R6 process
            if (p.Length > 0) // Check if window was found
            {
                SetForegroundWindow(p[0].MainWindowHandle); // Bring Siege to foreground
            }

            Refresh();

            // Clicks buttons in pre-game selection screen
            if (mouseClickX == 2645 && mouseClickY == 2000) // 4K
            {
                SendClick(413, 607, 50);
                SendClick(220, 565, 50);
                SendClick(522, 549, 50);
                SendClick(933, 374, 50);
            }
            else if (mouseClickX == 1760 && mouseClickY == 1330) // 1440p
            {
                SendClick(207, 404, 50);
                SendClick(145, 377, 50);
                SendClick(347, 371, 50);
                SendClick(622, 245, 50);
            }
            else if (mouseClickX == 1320 && mouseClickY == 990) // 1080p
            {
                SendClick(176, 301, 50);
                SendClick(108, 280, 50);
                SendClick(171, 276, 50);
                SendClick(465, 177, 50);
            }
            else // 768p
            {
                SendClick(144, 217, 50);
                SendClick(76, 202, 50);
                SendClick(183, 198, 50);
                SendClick(333, 128, 50);
            }

            // Click where the restart button is
            SendClick(mouseClickX, mouseClickY, 25);
        }

        void SendClick(int x, int y, int delay)
        {
            SetCursorPos(x, y);
            RelativeMove(2, 2);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
            System.Threading.Thread.Sleep(delay);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            System.Threading.Thread.Sleep(delay);
        }

        void WriteSettings()
        {
            try
            {
                if (Convert.ToInt32(CustomPosBoxX.Text) <= 0 || Convert.ToInt32(CustomPosBoxY.Text) <= 0)
                {
                    CustomPosBoxX.Text = "200";
                    CustomPosBoxY.Text = "200";
                }
            }
            catch (FormatException)
            {
                CustomPosBoxX.Text = "200";
                CustomPosBoxY.Text = "200";
            }
            catch (OverflowException)
            {
                CustomPosBoxX.Text = "200";
                CustomPosBoxY.Text = "200";
                SetMousePos(mouseClickX, mouseClickY);
            }
            

            /* 0 is Timer tick interval
             * 1 is last x pos
             * 2 is last y
             * 3 is custom x pos
             * 4 is custom y */
            
            // TODO Find a way to handle FormatException and OverflowException
            string[] lines = { "" + Convert.ToInt32(IntervalBox.Text), "" + mouseClickX, "" + mouseClickY, "" + Convert.ToInt32(CustomPosBoxX.Text), "" + Convert.ToInt32(CustomPosBoxY.Text) };

            File.WriteAllLines("settings.ini", lines);
        }

        #region Form button click events
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Try to convert the contents of the click timer box into an integer, otherwise show an error message.
            Int32.TryParse(IntervalBox.Text, out int interval);
            if (interval >= 225)
            {
                ClickTimer.Interval = interval;
                WriteSettings();
                ClickTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a value within 225 and 2147483647.", "Input Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ClickTimer.Enabled = false;
            WriteSettings();
        }

        private void Res4k_Click_1(object sender, EventArgs e)
        {
            mouseClickX = 2645;
            mouseClickY = 2000;

            SetMousePos(mouseClickX, mouseClickY);
            WriteSettings();
        }

        private void Res1440p_Click_1(object sender, EventArgs e)
        {
            mouseClickX = 1760;
            mouseClickY = 1330;

            SetMousePos(mouseClickX, mouseClickY);
            WriteSettings();
        }

        private void Res1080p_Click_1(object sender, EventArgs e)
        {
            mouseClickX = 1320;
            mouseClickY = 990;

            SetMousePos(mouseClickX, mouseClickY);
            WriteSettings();
        }

        private void Res768p_Click_1(object sender, EventArgs e)
        {
            mouseClickX = 950;
            mouseClickY = 710;

            SetMousePos(mouseClickX, mouseClickY);
            WriteSettings();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpMessage, "How to use", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                mouseClickX = Convert.ToInt32(CustomPosBoxX.Text);
                mouseClickY = Convert.ToInt32(CustomPosBoxY.Text);
            }
            catch (FormatException) { }
            catch (OverflowException) { }

            SetMousePos(mouseClickX, mouseClickY);
            WriteSettings();
            }
        #endregion
    }
}