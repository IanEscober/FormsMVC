using System;
using System.Windows.Forms;
using FormsMVC.Model;

namespace FormsMVC.View
{
    public partial class FormsMVCView : Form
    {
        public event EventHandler<SortEventArgs> SortEvent;

        public FormsMVCView(FormsMVCModel model)
        {
            InitializeComponent();
            Tb_Input.Text = model.Input;
            Cb_Sorting.SelectedIndex = (int)model.SortType;
            Lbl_Sorted_Value.Text = model.Output;
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            var input = Tb_Input.Text;

            var sortTypeIndex = Cb_Sorting.SelectedIndex;

            var sortEventArgs = new SortEventArgs
            {
                Input = input,
                SortTypeIndex = sortTypeIndex
            };

            SortEvent(this, sortEventArgs);
        }
    }
}
