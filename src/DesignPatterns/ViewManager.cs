using System.Threading;
using System.Windows.Forms;

namespace DesignPatterns
{
    public static class ViewManager
    {
        public static void Show(Form currentView, Form updatedView)
        {
            currentView.Close();
            currentView.Dispose();

            var thread = new Thread(() => Application.Run(updatedView));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
