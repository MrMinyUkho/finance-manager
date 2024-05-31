using System.Windows.Forms;

namespace FinanceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreditsDGV.AutoResizeColumns();
            CreditsDGV.AutoResizeRows();
            DebtsDGV.AutoResizeColumns();
            DebtsDGV.AutoResizeRows();
        }

        void FillDVGs()
        {

        }
    }
}
