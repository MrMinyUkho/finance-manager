using System;

namespace FinanceManager
{
    internal class Entry
    {
        public DateTime Date { get; set; }
        public float  Money { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }
    }
}
