using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollADO
{
    public class EmployeeRepo
    {
        private SqlConnection con;
        public void Connection()
        {
            string connectingString = "Data Source=(localdb)\\MSSQLLocaldb;Initial Catalog=Pay_Services";
        }
        public void AddEmployee(EmployeeModel emp)
        {
            try
            {
                Connection();
                SqlCommand command = new SqlCommand("SpAddEmployee", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", emp.Name);
                command.Parameters.AddWithValue("@Salary", emp.Salary);
                command.Parameters.AddWithValue("@StartDate", emp.StartDate);
                command.Parameters.AddWithValue("@Gender", emp.Gender);
                command.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
                command.Parameters.AddWithValue("@Department", emp.Department);
                command.Parameters.AddWithValue("@Deduction", emp.Deduction);
                command.Parameters.AddWithValue("@TaxablePay", emp.Taxablepayn);
                command.Parameters.AddWithValue("@IncomePay", emp.IncomePay);
                command.Parameters.AddWithValue("@NetPay", emp.NetPay);
                con.Open();
                int result = command.ExecuteNonQuery();
                con.Close();
                if (result != 0)
                {
                    Console.WriteLine("Data Added");
                }
                else
                {
                    Console.WriteLine("Data Not Added.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public List<EmployeeModel> GetEmployeeDetails()
        {
            Connection();
            List<EmployeeModel> EmpDetails = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("SpAddEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            con.Open();
            adapter.Fill(table);
            con.Close();
            foreach (DataRow dr in table.Rows)
            {

                EmpDetails.Add(
                    new EmployeeModel
                    {
                        ID = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Salary = Convert.ToInt32(dr["Salary"]),
                        StartDate = Convert.ToDateTime(dr["StartDate"]),
                        Gender = Convert.ToString(dr["Gender"]),
                        PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]),
                        Address = Convert.ToString(dr["Address"]),
                        Department = Convert.ToString(dr["Department"]),
                        BasicPay = Convert.ToInt32(dr["BasicPay"]),
                        Deduction = Convert.ToInt32(dr["Deduction"]),
                        TaxablePayn = Convert.ToInt32(dr["Taxablepayn"]),
                        IncomePay = Convert.ToInt32(dr["IncomePay"]),
                        NetPay = Convert.ToInt32(dr["NetPay"])
                    }
                            );
            }
            return EmpDetails;
        }
    }
}
