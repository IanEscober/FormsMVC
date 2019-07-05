using System.Threading;
using System.Windows.Forms;

namespace DesignPatterns
{
    public static class ViewManager
    {
        public static void Show(Form oldform, Form newForm)
        {
            oldform.Close();
            oldform.Dispose();

            var thread = new Thread(() => Application.Run(newForm));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
