﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace R6Clicker
{
    public partial class R6Clicker : Form
    {
        int mouseClickX = 860;
        int mouseClickY = 960;

        public R6Clicker()
        {
            // window size should be 815, 560
            InitializeComponent();

            IntervalBox.Text = ClickTimer.Interval.ToString();
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

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            SetCursorPos(mouseClickX, mouseClickY);
            Refresh();
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseClickX, mouseClickY, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, mouseClickX, mouseClickY, 0, 0);
        }
    }
}