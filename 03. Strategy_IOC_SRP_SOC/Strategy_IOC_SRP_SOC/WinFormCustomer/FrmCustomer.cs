using System;
using System.Windows.Forms;
using FactoryCustomer;
using InterfaceCustomer;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        private ICustomer Cust = null;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void CustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cust = Factory.Create(CustomerType.Text);
        }

        private void SetCustomer()
        {
            Cust.CustomerName = CustomerName.Text;
            Cust.PhoneNumber = PhoneNumber.Text;
            Cust.BillAmount = Convert.ToDecimal(BillAmount.Text);
            Cust.BillDate = Convert.ToDateTime(BillDate.Text);
            Cust.Address = Address.Text;
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                Cust.Validate();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CustomerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void BillAmount_TextChanged(object sender, EventArgs e)
        {

        }
        private void BillDate_TextChanged(object sender, EventArgs e)
        {

        }
        private void Address_TextChanged(object sender, EventArgs e)
        {

        }
        private void BillDateLabel_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
