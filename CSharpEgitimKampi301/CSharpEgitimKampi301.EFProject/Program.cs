using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());    form1 ekranı
            //Application.Run(new FrmLocation());  //artık FrmLocation formu etkin
            Application.Run(new FrmStatistics());  //artık FrmStatisticsn formu etkin 
        }
    }
}
