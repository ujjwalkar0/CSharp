namespace Program
{
    public class Employee1
    {
        public int ID;
        public string EmployeeName;
        public Employee1(int id, string employeename)
        {
            this.ID = id;
            this.EmployeeName = employeename;
        }
    }
    public class EmployeeSort : IComparer<Employee1>
    {
        public int Compare(Employee1? a, Employee1? b)
        {
            if (a?.ID == b?.ID) return 0;
            else if (a?.ID < b?.ID) return -1;
            return 1;
        }
        int IComparer.Compare(Object q, Object r)
        {
            return Compare((Point)q, (Point)r);
        }

    }
    class MyIComparer
    {
        public MyIComparer()
        {
            Employee[] employees = new Employee[]
            {
                new Employee(1, "Susmita"),
                new Employee(5, "Soniya"),
                new Employee(3, "Rohit"),
                new Employee(2, "Mohit"),
                new Employee(4, "Pihu")
            };

            Console.WriteLine("Before sorting employees array");
            foreach (var emp in employees)
            {
                Console.WriteLine("ID - {0}, Employee Name - {1}",
                                    emp.ID, emp.EmployeeName);
            }

            EmployeeSort.Sort(employees);

        }
    }
}