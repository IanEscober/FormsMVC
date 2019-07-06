using System;

namespace DesignPatterns.Model
{
    public class SortEventArgs : EventArgs
    {
        public string Input { get; set; }
        public int SortTypeIndex { get; set; }
    }
}