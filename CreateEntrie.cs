using System;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class CreateEntrie : Form
    {

        private Entry entry;

        public CreateEntrie(object entry = null)
        {
            InitializeComponent();
            this.entry = new Entry();
            if (entry != null )
            {
                Text = "EditEntry";
                createEntrie_btn.Text = "Змінити запис";
                this.entry = (Entry)entry;
                dateTimePicker1.Value = this.entry.Date;
                moneyText.Text = this.entry.Money.ToString();
                categoryText.Text = this.entry.Category;
                noteText.Text = this.entry.Note;
            }

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
