using System;
using System.Windows.Forms;
using DesignPatterns.Controller;

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
            var controller = new DesignPatternsController();
            Application.Run(controller.View);
        }
    }
}
