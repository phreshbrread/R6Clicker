using System;
using System.Windows.Forms;

namespace R6Clicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
                Application.Run(new R6Clicker());
            //}
            //catch (ArgumentOutOfRangeException)
            //{
                //MessageBox.Show("Please enter a value above 0", "Input Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Application.Restart();
            //}
        }
    }
}
