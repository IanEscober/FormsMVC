using System;
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
        private readonly ISortingService _sortingService; 

        public DesignPatternsView View { get; private set; }

        public DesignPatternsController(ISortingService sortingService)
        {
            _sortingService = sortingService ?? throw new NullReferenceException("SortingService");
            CreateView(new DesignPatternsModel());
        }

        public async Task<DesignPatternsView> SortInputAsync(DesignPatternsModel model)
        {
            if(model.IsValid())
            {
                model.Output = await _sortingService.ApplySortingAsync(model); 
            }
            else
            {
                model.Output = "Input should only contain [A-Z , a-z]";
            }

            CreateView(model);
            return View;
        }

        private void CreateView(DesignPatternsModel model)
        {
            View = new DesignPatternsView(model);
            View.SortEvent += (s,e) =>
                ViewManager.UpdateViewAsync(View, SortInputAsync, e.Parse());
        }
    }
}
