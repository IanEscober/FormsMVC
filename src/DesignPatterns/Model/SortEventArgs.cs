using System;

namespace DesignPatterns.Model
{
    public class SortEventArgs : EventArgs
    {
        public string Input { get; set; }
        public string SortType { get; set; }
    }
}