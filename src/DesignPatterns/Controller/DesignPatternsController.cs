using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatterns.View;
using DesignPatterns.Model;
using DesignPatterns.Service;
using DesignPatterns.Parsing;
using DesignPatterns.Validation;
using System.Threading;

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
