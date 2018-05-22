using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFireWinForm
{
    class Employees
    {
        private string ConnectionString = "Server=(local);Database=Employees;Trusted_Connection=True;";

        private SqlConnection _connection;
        //-----------------------------------------------------------------
        public bool OpenConnection()
        {
            try
            {
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //-----------------------------------------------------------------
        public void CloseConnection()
        {
            if (_connection != null)
                _connection.Close();
        }
        //-----------------------------------------------------------------
        private string FormatDate(string date)
        {
            if (date != "")
            {
                date = date.Remove(9);
            }
            
            return date;
        }
        //-----------------------------------------------------------------
        public List<Worker> GetAllWorkers()
        {
            try
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = "SELECT * FROM Employees";
                SqlDataReader reader = command.ExecuteReader();
                List<Worker> workers = new List<Worker>();

                while (reader.Read())
                {
                    Worker worker = new Worker();

                    worker.BusinessEntityID = Convert.ToInt32(reader["BusinessEntityID"]);
                    worker.Title = Convert.ToString(reader["Title"]);
                    worker.FirstName = Convert.ToString(reader["FirstName"]);
                    worker.MiddleName = Convert.ToString(reader["MiddleName"]);
                    worker.LastName = Convert.ToString(reader["LastName"]);
                    worker.Suffix = Convert.ToString(reader["Suffix"]);
                    worker.JobTitle = Convert.ToString(reader["JobTitle"]);
                    worker.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    worker.PhoneNumberType = Convert.ToString(reader["PhoneNumberType"]);
                    worker.EmailAddress = Convert.ToString(reader["EmailAddress"]);
                    worker.AddressLine1 = Convert.ToString(reader["AddressLine1"]);
                    worker.AddressLine2 = Convert.ToString(reader["AddressLine2"]);
                    worker.City = Convert.ToString(reader["City"]);
                    worker.StateProvinceName = Convert.ToString(reader["StateProvinceName"]);
                    worker.PostalCode = Convert.ToString(reader["PostalCode"]);
                    worker.CountryRegionName = Convert.ToString(reader["CountryRegionName"]);
                    worker.StartDate = Convert.ToDateTime(FormatDate(reader["StartDate"].ToString()));

                    string tempEndDate = FormatDate(reader["EndDate"].ToString());

                    worker.EndDate = Convert.ToDateTime(tempEndDate == "" ? null : tempEndDate);
                    //worker.EndDate = Convert.ToDateTime(value: reader["EndDate"].ToString() == "" ? null : reader["EndDate"].ToString());

                    workers.Add(worker);
                }

                reader.Close();
                return workers;
            }
            catch (SqlException) 
            {
                return null;   
            }
        }
        //-----------------------------------------------------------------
        public bool FiredWorker(int id)
        {
            try
            {
                var result = MessageBox.Show("Fired?", "Caution!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SqlCommand command = _connection.CreateCommand();
                    command.CommandText = "UPDATE Employees SET EndDate = FORMAT(GETDATE(), N'yyyy-MM-dd') WHERE BusinessEntityID = @id";

                    SqlParameter parameter = new SqlParameter("id", id);
                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();

                    return true;
                }

                return false;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        //-----------------------------------------------------------------
    }
}
