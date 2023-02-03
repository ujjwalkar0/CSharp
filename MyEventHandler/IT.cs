using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEventHandler
{
    public class IT
    {
        private readonly EmployeeSeperator? employeeSeperator;
        public IT(EmployeeSeperator employeeSeparator)
        {
            this.employeeSeperator = employeeSeparator;
            employeeSeparator.EmployeeSeperated += EmployeeSeparatedEventHandler;
        }
        public void EmployeeSeparatedEventHandler() { 
            System.Console.WriteLine("IT department: employee separation method related to IT"); 
        }
    }
}