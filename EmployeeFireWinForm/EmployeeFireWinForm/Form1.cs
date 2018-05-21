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

        public fEmployeesList()
        {
            InitializeComponent();

            if (!_db.OpenConnection())
            {
                MessageBox.Show("Some Errors!");
                Close();
            }

            List<Worker> workers = _db.GetAllWorkers();

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

        }
        //---------------------------------------------------------------------
        private void fEmployeesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.CloseConnection();
        }
        //---------------------------------------------------------------------
        private void lbEmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
