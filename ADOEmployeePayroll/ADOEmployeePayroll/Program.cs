﻿using System;
using ADOEmployeePayroll;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome in the Employee Pay Roll Service");
        EmployeeRepo payrollService = new EmployeeRepo();
        bool check = true;


        while (check)
        {
            Console.WriteLine("1. To Insert the Data in Data Base \n");
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmpModel empModel = new EmpModel();
                    empModel.Id = 111;
                    empModel.Name = "megha";
                    empModel.Salary = 50000;
                    empModel.StartDate = DateTime.Now;
                    empModel.Gender = "M";
                    empModel.ContactNumber = "9009099878";

                    empModel.Address = "banglore";
                    empModel.Pay = 500;
                    empModel.Deduction = 500;
                    empModel.Texable = 500;
                    empModel.IncomeTax = 500;
                    empModel.NetPay = 2000;
                    payrollService.AddEmp(empModel);
                    break;
                case 0:
                    check = false;
                    break;
                default:
                    Console.WriteLine("Please Enter the Correct option");
                    break;
            }
        }

    }
}