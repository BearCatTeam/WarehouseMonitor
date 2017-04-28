using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SnailWareHouse
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (!File.Exists("snailWHdb.db3"))
            {
                SQLiteConnection.CreateFile("snailWHdb.db3");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
