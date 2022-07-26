using Sqlite.Database.Connection.Models;
using Sqlite.Database.Connection.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite.Database.Connection.Forms
{
    public partial class EmployeeDetails : Form
    {
        int employeeId;
        public EmployeeDetails(int employeeId)
        {
            InitializeComponent();
            this.employeeId= employeeId;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            GetEmployeeById();
            GetCustomersByEmployeeId();
        }
        
        void GetEmployeeById()
        {
            using(EmployeeRepository employeeRepository = new EmployeeRepository())
            {
                Employee dataItem = employeeRepository.GetDataById(employeeId);
                if(dataItem != null)
                {
                    txt_title.Text = dataItem.Title;
                    txt_firstname.Text = dataItem.FirstName;
                    txt_lastname.Text = dataItem.LastName;
                    txt_birth.Text = dataItem.BirthDate.ToString("dd.MM.yyyy");
                    txt_hdate.Text = dataItem.HireDate.ToString("dd.MM.yyyy");

                    txt_country.Text = dataItem.Country;
                    txt_city.Text = dataItem.City;
                    txt_state.Text = dataItem.State;
                    txt_address .Text = dataItem.Address;

                    txt_postalcode.Text = dataItem.PostalCode;
                    txt_phone.Text = dataItem.Phone;
                    txt_fax.Text = dataItem.Fax;
                    txt_email.Text = dataItem.Email;
                }
            }
        }

        void GetCustomersByEmployeeId()
        {
            using(CustomerRepository customerRepository = new CustomerRepository())
            {
                grdCustomers.DataSource = customerRepository.GetAllByEmployeeId(employeeId);
            }
        }

        private void lblUnvan_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerId = (int) grdCustomers.Rows[e.RowIndex].Cells[0].Value;
            InvoiceDetail invoiceDetailForm = new InvoiceDetail(customerId);
            invoiceDetailForm.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using(EmployeeRepository employeeRepository = new EmployeeRepository())
            {
                employeeRepository.UpdateEmployee(txt_postalcode.Text, txt_phone.Text, txt_fax.Text, txt_email.Text, employeeId);
            }
        }
    }
}
