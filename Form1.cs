using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class Form1 : Form
    {

        List<Entry> entries = new List<Entry>();

        public Form1()
        {
            InitializeComponent();
            
            LoadData();
            
            CreditsDGV.AutoResizeColumns();
            CreditsDGV.AutoResizeRows();
            DebtsDGV.AutoResizeColumns();
            DebtsDGV.AutoResizeRows();
        }


        #region FileWorks

        void SaveData()
        {
            using (FileStream stream = new FileStream("data.bin", FileMode.Create))
                new BinaryFormatter().Serialize(stream, entries);
        }

        void LoadData()
        {
            if (!File.Exists("data.bin")) return;
            using (FileStream stream = new FileStream("data.bin", FileMode.Open))
                entries = (List<Entry>)new BinaryFormatter().Deserialize(stream);
        }

        void DeleteData()
        {
            if (!File.Exists("data.bin")) return;
            File.Delete("data.bin");
        }

        #endregion

        #region Tools

        void FillDVGs()
        {

        }

        #endregion
    }
}
