using System;
using System.Windows.Forms;

namespace Virüs_Antivirüs  // BURASI PROJE ADINLA AYNI OLDU
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}