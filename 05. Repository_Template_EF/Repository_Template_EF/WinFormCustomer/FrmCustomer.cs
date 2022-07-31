using System;
using System.Windows.Forms;
using FactoryCustomer;
using InterfaceCustomer;
using InterfaceDal;
using FactoryDal;
using System.Collections.Generic;

namespace WinFormCustomer
{
    // Important => Converted all ICustomer to CustomerBase bcoz of ef mapping
    public partial class FrmCustomer : Form
    {
        private CustomerBase Cust = null;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void CustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cust = Factory<CustomerBase>.Create(CustomerType.Text);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetCustomer();
            // DAL Operation
            IDal<CustomerBase> dal = FactoryClass<IDal<CustomerBase>>.Create("ADODal");
            dal.Add(Cust);  // In memory
            dal.Save();  // Physical commit
            LoadGrid();
        }


        // Loading UI
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            dalComboBox.Items.Add("ADODAL");
            dalComboBox.Items.Add("EFDAL");
            LoadGrid();
        }

        private void LoadGrid()
        {
            IDal<CustomerBase> Idal = FactoryClass<IDal<CustomerBase>>.Create("ADODal");
            List<CustomerBase> custs = Idal.Search();
            dataGrid.DataSource = custs;
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

        private void dalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
