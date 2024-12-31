using System;
using System.Windows.Forms;

namespace RDPAcessor
{
    static class Runtime
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RMain());
        }
    }
}
