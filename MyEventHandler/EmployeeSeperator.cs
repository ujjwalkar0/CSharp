namespace MyEventHandler
{
    public class EmployeeSeperator
    {
        public delegate void EmployeeSeperatorEventHandler();
        public event EmployeeSeperatorEventHandler? EmployeeSeperated;

        public void Seperate()
        {
            EmployeeSeperated?.Invoke();
        }
    }
}