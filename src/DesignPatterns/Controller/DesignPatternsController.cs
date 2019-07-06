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

        public DesignPatternsView SortInput(DesignPatternsModel model)
        {
            if(model.IsValid())
            {
                model.Output = model.Input.Sort(model.SortType);
            }
            else
            {
                model.Output = "Input should only contain [A-Z a-z]";
            }

            CreateView(model);
            return View;
        }

        private void OnSortEvent(object sender, SortEventArgs args)
        {
            var model = args.Parse();
            ViewManager.Show(View, SortInput(model));
        }

        private void CreateView(DesignPatternsModel model)
        {
            View = new DesignPatternsView(model);
            View.SortEvent += OnSortEvent;
        }
    }
}
