using System.Threading.Tasks;
using DesignPatterns.View;
using DesignPatterns.Model;
using DesignPatterns.Service;
using DesignPatterns.Parsing;
using DesignPatterns.Validation;

namespace DesignPatterns.Controller
{
    public class DesignPatternsController
    {
        public DesignPatternsView View { get; private set; }

        public DesignPatternsController()
        {
            CreateView(new DesignPatternsModel());
        }

        public async Task<DesignPatternsView> SortInput(DesignPatternsModel model)
        {
            if(model.IsValid())
            {
                var input = model.Input;
                var sortedInput = input.SortAsync(model.SortType);
                model.Output = await sortedInput;
            }
            else
            {
                model.Output = "Input should only contain [A-Z , a-z]";
            }

            CreateView(model);
            return View;
        }

        private async void OnSortEvent(object sender, SortEventArgs args)
        {
            var currentView = View; // or sender as Forms
            var model = args.Parse();
            var updatedView = await SortInput(model);
            ViewManager.Show(currentView, updatedView);
        }

        private void CreateView(DesignPatternsModel model)
        {
            View = new DesignPatternsView(model);
            View.SortEvent += OnSortEvent;
        }
    }
}
