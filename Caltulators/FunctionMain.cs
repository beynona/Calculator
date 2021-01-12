using System;
using System.Windows.Forms;
namespace Caltulators
{
    static class FunctionMain 
    {
        [STAThread]
        static void Main()
        {
            StartForm();
        }

        private static void StartForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Caltulator());
        }
        
    }
}
