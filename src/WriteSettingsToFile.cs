using System.IO;

namespace R6Clicker
{
    public class FileRW
    {
        public static void WriteSettings(int timerTickInterval, int mX, int mY, int cusX, int cusY)
        {
            /*
            Entry 0 is last x
            1 is last y
            2 is last timer tick
            3 is custom x
            4 is custom y
            */

            string[] lines = { "" + timerTickInterval, "" + mX, "" + mY, "" + cusX, "" + cusY };

            File.WriteAllLines("settings.ini", lines);
        }
    }
}
