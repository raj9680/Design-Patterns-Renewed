using System;
using System.Windows.Forms;
using FactoryCustomer;
using InterfaceCustomer;
using InterfaceDal;
using FactoryDal;
using System.Collections.Generic;

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
            Cust = Factory<ICustomer>.Create(CustomerType.Text);
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
            IDal<ICustomer> dal = Factory<IDal<ICustomer>>.Create("ADODal");
            dal.Add(Cust);  // In memory
            dal.Save();  // Physical commit
        }


        // Loading UI
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            IDal<ICustomer> Idal = FactoryClass<IDal<ICustomer>>.Create("ADODal");
            List<ICustomer> custs = Idal.Search();
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

        
    }
}
