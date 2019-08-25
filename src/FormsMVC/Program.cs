using System;
using System.Windows.Forms;
using FormsMVC.Controller;
using FormsMVC.Service;

namespace FormsMVC
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
            var controller = new FormsMVCController(sortingServiceInstance);

            Application.Run(controller.View);
        }
    }
}
