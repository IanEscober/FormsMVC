using System;

namespace FormsMVC.Model
{
    public class SortEventArgs : EventArgs
    {
        public string Input { get; set; }
        public int SortTypeIndex { get; set; }
    }
}