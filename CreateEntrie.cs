using System;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class CreateEntrie : Form
    {

        private Entry entry;

        public CreateEntrie()
        {
            InitializeComponent();
            entry = new Entry();
        }

        public object GetEntry()
        {
            return entry;
        }

        private void createEntrie_btn_Click(object sender, EventArgs e)
        {
            entry.Date = dateTimePicker1.Value;
            if (!float.TryParse(moneyText.Text, out entry.Money)) MessageBox.Show("Невірно вказана сума");
            entry.Category = categoryText.Text;
            entry.Note = noteText.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
