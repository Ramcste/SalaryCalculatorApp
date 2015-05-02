using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using basicAmountCalculatorApp;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.employeeName = employeeNameTextBox.Text;
            employee.basicAmount = double.Parse(employeeBasicAmountTextBox.Text);

            employee.GetHouseRent(double.Parse(houseRentTextBox.Text));
            employee.GetMedicalAllowance(double.Parse(medicalAllowanceTextBox.Text));
            MessageBox.Show(employee.employeeName+" ,your salary is: "+employee.GetEmployeeSalary());


        }
    }
}
