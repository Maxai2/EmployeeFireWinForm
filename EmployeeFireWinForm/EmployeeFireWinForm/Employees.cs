using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    worker.StartDate = Convert.ToString(reader["StartDate"]);
                    worker.EndDate = Convert.ToString(reader["EndDate"]);

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
        public void FiredWorker(int id)
        {
            try
            {
                SqlCommand command = _connection.CreateCommand();
                command.CommandText = "UPDATE Employees SET EndDate = FORMAT(GETDATE(), N'yyyy/MM/dd') WHERE BusinessEntityID = @id";
            }
            catch (SqlException)
            {

                throw;
            }
        }
        //-----------------------------------------------------------------
    }
}
