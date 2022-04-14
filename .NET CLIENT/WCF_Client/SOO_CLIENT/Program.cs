using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOO_CLIENT
{
    static class Program
    {
        public static string authToken = null;
        public static string userUuid = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LOGIN());
            //Application.Run(new SERVICE_ORCHESTRATION());
        }
    }
}
