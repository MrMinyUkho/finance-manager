using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class GetSummary : Form
    {
        List<Entry> Entries;
        public GetSummary(List<Entry> Entries)
        {
            this.Entries = Entries;
            InitializeComponent();
        }

        private void getSummary_btn_Click(object sender, EventArgs e)
        {
            if (Start_dTP.Value > End_dTP.Value && !periodCheck.Checked)
            {
                MessageBox.Show("Початковий час більше ніж кінцевий");
                return;
            }

            float debts = 0, credit = 0;

            if (periodCheck.Checked)
            {
                debts  = Entries.Where(a => a.Money > 0).Sum(a => a.Money);
                credit = Entries.Where(a => a.Money < 0).Sum(a => a.Money);
            }
            else
            {
                debts  = Entries.Where(a => a.Money > 0 && a.Date > Start_dTP.Value && a.Date < End_dTP.Value).Sum(a => a.Money);
                credit = Entries.Where(a => a.Money < 0 && a.Date > Start_dTP.Value && a.Date < End_dTP.Value).Sum(a => a.Money);
            }
            
            Debit_tb.Text = debts.ToString();
            Credit_tb.Text = credit.ToString();

            Size = new Size(297, 255);
        }

        private void periodCheck_CheckedChanged(object sender, EventArgs e)
        {
            Start_dTP.Enabled = !periodCheck.Checked;
            End_dTP.Enabled   = !periodCheck.Checked;
        }
    }
}
