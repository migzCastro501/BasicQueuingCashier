using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        private CashierClass cashier;
        CustomerView form2 = new CustomerView();
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick); //timer1_tick represents the name of Tick Event
            timer.Start();

            cashier = new CashierClass();
            form2.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(CashierClass.CashierQueue.Count > 0)
            {
                string servedCustomer = CashierClass.CashierQueue.Dequeue();
                MessageBox.Show("ServedCustomer, "+ servedCustomer);
                DisplayCashierQueue(CashierClass.CashierQueue);
                form2.UpdateNowServing(servedCustomer);
            }
            else
            {
                MessageBox.Show("No customers in queue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
