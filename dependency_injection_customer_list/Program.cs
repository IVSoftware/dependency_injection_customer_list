using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // See this SO answer:
            // [Using Microsoft Extension Dependency Injection on WinForms in C#]
            // (https://stackoverflow.com/questions/47516409/using-microsoft-extension-dependency-injection-on-winforms-in-c-sharp)
            ConfigureServices();
            Application.Run(new Main());
        }
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IRepo<Customer>, CustomersRepo>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
