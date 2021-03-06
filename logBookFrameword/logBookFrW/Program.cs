using Micron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logBookFrameword
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            MicronConfig config = new MicronConfig()
            {
                DatabaseName = "logBook",
                Host = "127.0.0.1",
                User = "root",
                Password = "0000",
                Port = "3306"
            };

            MicronDbContext db = new MicronDbContext(config);
            MicronDbContext.AddConnectionSetup(config);
            var micron = new MicronDbContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());

        }
    }
}
