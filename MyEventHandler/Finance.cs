using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEventHandler
{
    class Finance
    {
        private readonly EmployeeSeperator? employeeSeperator;
        public Finance(EmployeeSeperator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;
        }

        public void EmployeeSeperatedEventHandler(){
            System.Console.WriteLine("Finance Depertment: Employee Seperation process related to finance...");
        }
    }
}