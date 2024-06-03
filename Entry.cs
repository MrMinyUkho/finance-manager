using System;

namespace FinanceManager
{
    [Serializable]
    class Entry
    {
        public DateTime Date;
        public float Money;
        public string Category;
        public string Note;

        public string getDate()
        {
            return $"{Date.Day}.{Date.Month}.{Date.Year} {Date.Hour}:{Date.Minute}";
        }
    }
}
