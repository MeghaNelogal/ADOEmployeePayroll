using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollADO
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public int BasicPay { get; set; }
        public int Deduction { get; set; }
        public int Taxablepayn { get; set; }
        public int IncomePay { get; set; }
        public int NetPay { get; set; }
    }
}