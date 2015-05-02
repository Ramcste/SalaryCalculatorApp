using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicAmountCalculatorApp
{
    class Employee
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowance;
        

        public double GetMedicalAllowance(double medicalAllowancePercent) 
        {
           medicalAllowance= basicAmount * medicalAllowancePercent/100;

           return medicalAllowance;

        }


        public double GetHouseRent(double houseRentPercent)
        {
             houseRent=basicAmount * houseRentPercent/100;
             return houseRent;

        }

        public double GetEmployeeSalary()
        {
            return basicAmount + (medicalAllowance + houseRent);
        }



    }
}
