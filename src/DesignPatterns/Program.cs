using System;
using System.Windows.Forms;
using DesignPatterns.Controller;
using DesignPatterns.Service;

namespace DesignPatterns
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var sortingServiceInstance = new SortingService();
            var controller = new DesignPatternsController(sortingServiceInstance);

            Application.Run(controller.View);
        }
    }
}
