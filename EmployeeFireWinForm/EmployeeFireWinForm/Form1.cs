using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------------------------------------------------------------------
namespace EmployeeFireWinForm
{
    public partial class fEmployeesList : Form
    {
        private Employees _db = new Employees();

        List<Worker> workers = new List<Worker>();

        public fEmployeesList()
        {
            InitializeComponent();

            if (!_db.OpenConnection())
            {
                MessageBox.Show("Some Errors!");
                Close();
            }

            workers = _db.GetAllWorkers();

            if (workers != null)
            { 
                lbEmployeesList.DataSource = workers;
                lbEmployeesList.DisplayMember = "Info";
                lbEmployeesList.ValueMember = "BusinessEntityID";
            }
        }
        //---------------------------------------------------------------------
        private void bFired_Click(object sender, EventArgs e)
        {
            int index = lbEmployeesList.SelectedIndex + 1;

            if (index != -1)
            {
                if (_db.FiredWorker(index))
                {
                    workers[index].EndDate = DateTime.Today.Date.ToString("dd-MMM-yy");

                    tbEndDate.Text = workers[index].EndDate.ToString();
                }
            }
        }
        //---------------------------------------------------------------------
        private void fEmployeesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.CloseConnection();
        }
        //---------------------------------------------------------------------
        private void lbEmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployeesList.SelectedIndex != -1)
            {
                int index = lbEmployeesList.SelectedIndex;

                tbFirstName.Text = (workers[index].Title != "" ? (workers[index].Title + " ") : "") + workers[index].FirstName;
                tbLastName.Text = workers[index].LastName;
                tbMiddleName.Text = workers[index].MiddleName + (workers[index].Suffix != "" ? workers[index].Title : "");
                tbJobTitle.Text = workers[index]?.JobTitle;
                tbPhone.Text = workers[index]?.PhoneNumber;
                tbEmail.Text = workers[index]?.EmailAddress;
                tbAddress.Text = workers[index]?.AddressLine1 + (workers[index].AddressLine2 != "" ? (", " + workers[index].AddressLine2) : "");
                tbCity.Text = workers[index]?.City;
                tbState.Text = workers[index]?.StateProvinceName;
                tbRegion.Text = workers[index]?.CountryRegionName;
                tbPostCode.Text = workers[index]?.PostalCode;
                tbStartDate.Text = workers[index].StartDate.ToString();
                tbEndDate.Text = workers[index].EndDate.ToString();
            }
        }
    }
}
