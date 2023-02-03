namespace MyEventHandler
{
    class Class1
    {
        public Class1()
        {
            EmployeeSeperator employeeSeperator = new EmployeeSeperator();
            Finance finance = new Finance(employeeSeperator);
            IT it = new IT(employeeSeperator); 
            employeeSeperator.Seperate();
        }
    }
}