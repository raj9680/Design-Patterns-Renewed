using MiddleLayer;
using System;
using System.Windows.Forms;
using FactoryCustomer;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        /// private Customer cust = null;   private Lead lead = null;
        // Common object creation for both Customer & Lead -- Polymorphism(change as per situation)
        private CustomerBase Cust = null;    // - X
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void BillDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // We are creating objects here, best approach to have centralized class for all object creation (Factory Design Pattern) so
            // moved that part to another class/project FactoryCustomer
            /// if (CustomerType.Text == "Customer")
            /// {
            ///    Cust = new Customer();
            /// }
            /// else
            /// {
            ///     Cust = new Lead();
            /// }

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
            /// Object Creation
            // if(CustomerType.Text == "Customer")
            // {
            //     Cust.Validate();
            // }
            // else
            // {
            //     Cust.Validate();
            // }

            // Because of X we can use only below approach instead of above approach
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
    }
}
