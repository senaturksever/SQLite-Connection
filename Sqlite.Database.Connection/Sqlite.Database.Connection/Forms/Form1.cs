using Sqlite.Database.Connection.Forms;
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

namespace Sqlite.Database.Connection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }

        void GetEmployees()
        {
            using (EmployeeRepository employeeRepository  = new EmployeeRepository())
            {
                grdEmp.DataSource = employeeRepository.GetAll();
            }
        }

        private void grdEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var employeeId = (int) grdEmp.Rows[e.RowIndex].Cells[0].Value;
            //Form Yönlendirme...
            EmployeeDetails employeeDetailForm = new EmployeeDetails(employeeId);
            employeeDetailForm.ShowDialog();
        }
    }
}
