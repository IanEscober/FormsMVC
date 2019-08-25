using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMVC
{
    public static class ViewManager
    {
        public static void UpdateView<T, U>(Form currentView, Func<T,U> updater, T model)
        {
            var updatedView = updater(model);
            Update(currentView, updatedView as Form);
        }

        public static async void UpdateViewAsync<T, U>(Form currentView, Func<T,Task<U>> updater, T model)
        {
            var updatedView = await updater(model);
            Update(currentView, updatedView as Form);
        }

        public static void Update(Form currentView, Form updatedView)
        {
            currentView.Close();
            currentView.Dispose();

            var thread = new Thread(() => Application.Run(updatedView));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
