using System;
using System.Windows.Forms;

namespace GuiaEntity
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Form1 se ejecuta primero
            Application.Run(new Form1());
        }
    }
}
