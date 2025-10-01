using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisProject
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
            Application.Run(new Számológép());
            int a = 0;
            if (a == 0)
            {
                Console.WriteLine("Ez nulla.");
            }

            for (int i = -10; i < 0; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
