using System;
using System.Threading.Tasks;
using FormsMVC.View;
using FormsMVC.Model;
using FormsMVC.Service;
using FormsMVC.Parsing;
using FormsMVC.Validation;

namespace FormsMVC.Controller
{
    public class FormsMVCController
    {
        private readonly ISortingService _sortingService; 

        public FormsMVCView View { get; private set; }

        public FormsMVCController(ISortingService sortingService)
        {
            _sortingService = sortingService ?? throw new NullReferenceException("SortingService");
            CreateView(new FormsMVCModel());
        }

        public async Task<FormsMVCView> SortInputAsync(FormsMVCModel model)
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

        private void CreateView(FormsMVCModel model)
        {
            View = new FormsMVCView(model);
            View.SortEvent += (s,e) =>
                ViewManager.UpdateViewAsync(View, SortInputAsync, e.Parse());
        }
    }
}
