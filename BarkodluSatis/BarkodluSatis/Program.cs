using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isMutexCreated = true;
            using (Mutex mutex=new Mutex(true,"BarkodluSatisProgrami",out isMutexCreated))
            {
                if (isMutexCreated)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FrmLogin());
                }
                else
                {
                    MessageBox.Show("Program iki kez çalıştırılamaz!");
                }
            }
            
            
        }
    }
}
