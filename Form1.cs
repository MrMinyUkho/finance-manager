using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
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
            var Debts   = (from entrie in entries where entrie.Money  > 0 select entrie).ToList(); 
            var Credits = (from entrie in entries where entrie.Money <= 0 select entrie).ToList();

            DebtsDGV.RowCount = Debts.Count;
            CreditsDGV.RowCount = Credits.Count;

            for (int i = 0; i < Debts.Count; i++)
            {
                DebtsDGV.Rows[i].Cells[0].Value = Debts[i].getDate();
                DebtsDGV.Rows[i].Cells[1].Value = Debts[i].Money;
                DebtsDGV.Rows[i].Cells[2].Value = Debts[i].Category;
                DebtsDGV.Rows[i].Cells[3].Value = Debts[i].Note;
            }
            for (int i = 0; i < Credits.Count; i++)
            {
                CreditsDGV.Rows[i].Cells[0].Value = Credits[i].getDate();
                CreditsDGV.Rows[i].Cells[1].Value = Credits[i].Money;
                CreditsDGV.Rows[i].Cells[2].Value = Credits[i].Category;
                CreditsDGV.Rows[i].Cells[3].Value = Credits[i].Note;
            }

            new Thread(() => { 
                Thread.Sleep(50);
                Invoke((MethodInvoker)(() => {
                    CreditsDGV.AutoResizeColumns();
                    CreditsDGV.AutoResizeRows();
                    DebtsDGV.AutoResizeColumns();
                    DebtsDGV.AutoResizeRows();
                }));
            }).Start();
        }

        #endregion
    }
}
