using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm CashierWindowQueueForm = new CashierWindowQueueForm();
        public QueuingForm()
        {

            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm.Show();
        }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
           
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click_1(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
