using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class Form1 : Form
    {

        List<Entry> entries = new List<Entry>();
        List<Entry> entriesf = new List<Entry>();
        HashSet<string> filtrs = new HashSet<string>();

        DataGridView lastSelect = null;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            FillDGVs();
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

            filtrs = (from entry in entries select entry.Category).ToHashSet();

            selectFilterBox.Items.Clear();

            for (int i = 0; i < filtrs.Count; ++i)
            {
                selectFilterBox.Items.Add(filtrs.ElementAt(i));
                selectFilterBox.SetItemChecked(i, true);
            }
        }

        void DeleteData()
        {
            if (!File.Exists("data.bin")) return;
            File.Delete("data.bin");
        }

        #endregion

        #region Tools

        void FillDGVs()
        {
            applySortFilter();

            var Debts   = (from entrie in entriesf where entrie.Money  > 0 select entrie).ToList(); 
            var Credits = (from entrie in entriesf where entrie.Money <= 0 select entrie).ToList();

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

        void disableAllCheck()
        {
            SortCategoryAZ.Checked = false;
            SortCategoryZA.Checked = false;

            SortDateAZ.Checked = false;
            SortDateZA.Checked = false;

            SortMoneyAZ.Checked = false;
            SortMoneyZA.Checked = false;

            SortNoteAZ.Checked = false;
            SortNoteZA.Checked = false;
        }

        void applySortFilter()
        {
            entriesf.Clear();

            if (SortCategoryAZ.Checked) entriesf = (from entry in entries orderby entry.Category            select entry).ToList();
            if (SortCategoryZA.Checked) entriesf = (from entry in entries orderby entry.Category descending select entry).ToList();

            if (SortMoneyAZ.Checked)    entriesf = (from entry in entries orderby entry.Money               select entry).ToList();
            if (SortMoneyZA.Checked)    entriesf = (from entry in entries orderby entry.Money    descending select entry).ToList();

            if (SortDateAZ.Checked)     entriesf = (from entry in entries orderby entry.Date                select entry).ToList();
            if (SortDateZA.Checked)     entriesf = (from entry in entries orderby entry.Date     descending select entry).ToList();

            if (SortNoteAZ.Checked)     entriesf = (from entry in entries orderby entry.Note                select entry).ToList();
            if (SortNoteZA.Checked)     entriesf = (from entry in entries orderby entry.Note     descending select entry).ToList();

            if (entriesf.Count == 0)    entriesf = (from entry in entries select entry).ToList();

            entriesf = entriesf.Where(x => selectFilterBox.CheckedItems.Cast<string>().Contains(x.Category)).ToList();
        }

        #endregion

        #region NonExplicitEvents

        private void CreditsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelect = (DataGridView)sender;
        }

        private void DebtsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelect = (DataGridView)sender;
        }

        #endregion

        #region ExplicitEvents

        // Создать запись
        void createEntry_btn_Click(object sender, EventArgs e)
        {
            var form = new CreateEntrie();
            if (form.ShowDialog() == DialogResult.OK)
                entries.Add((Entry)form.GetEntry());
            FillDGVs();
        }

        // Удалить запись
        private void deleteEntry_btn_Click(object sender, EventArgs ev)
        {
            if (lastSelect is null) return;
            var row = lastSelect.Rows[lastSelect.CurrentCell.RowIndex];
            Entry entry = (from e 
                           in entries 
                           where e.getDate() == (string)row.Cells[0].Value &&
                                 e.Category  == (string)row.Cells[2].Value
                           select e).ToList()[0];
            entries.Remove(entry);
            FillDGVs();
        }


        // Сохранить записи
        private void saveData_btn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        // Выбрать как сортировать
        private void changeSortSettings(object sender, EventArgs e)
        {
            var cbox = (CheckBox)sender;
            disableAllCheck();
            cbox.Checked = true;
            FillDGVs();
        }

        // Применить фильтр
        private void selectFilterBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            new Thread(() => // Снятие чека происходит только после выполнения хендлера события
            {                // По этому надо запустить поток, который немного ждёт, чтобы все изменения применились
                Thread.Sleep(500);
                Invoke((MethodInvoker)(() => {
                    FillDGVs();
                }));
            }).Start();
        }

        #endregion
    }
}
