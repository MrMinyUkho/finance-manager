using System;

namespace FinanceManager
{
    [Serializable]
    internal class Entry
    {
        public DateTime Date { get; set; }
        public float  Money { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }

        public string getDate()
        {
            return $"{Date.Date} {Date.Hour}:{Date.Minute}";
        }
    }
}
