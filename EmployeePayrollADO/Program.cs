using System;
using EmployeePayrollADO;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("\t\t\t\t\tWELCOME TO EMPLOYEE PAROLL SERVICE PROGRAM !\t\t\t\t\t\n");
        EmployeeRepo payrollService = new EmployeeRepo();
        bool verify = true;

        while (verify)
        {
            Console.WriteLine("\nEnter\n1. To insert data into database\n2.Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmployeeModel addMdl = new EmployeeModel();
                    addMdl.Name = "Megha";
                    addMdl.Salary = 2000;
                    addMdl.StartDate = Convert.ToDateTime("07-02-2017");
                    addMdl.Gender = "F";
                    addMdl.PhoneNumber = 9123456;
                    addMdl.Address = "Bangalore";;
                    addMdl.Department = "Sales";
                    addMdl.BasicPay = 10000;
                    addMdl.Deduction = 500;
                    addMdl.Taxablepayn = 500;
                    addMdl.IncomePay = 500;
                    addMdl.NetPay = 2000;
                    payrollService.AddEmployee(addMdl);
                    break;
                case 2:
                    verify = false;
                    break;
                default:
                    Console.WriteLine("Enter valid option !\n");
                    break;
            }
        }
    }
}