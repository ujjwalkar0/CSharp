// dynamic type and ann obj.
// name, role, marks of 3 sub
using System.Dynamic;

namespace Program{
    class Task2{
        public Task2(){

            dynamic student = new ExpandoObject();

            System.Console.WriteLine("Enter name of Student...");
            student.name=System.Console.ReadLine()!;

            System.Console.WriteLine("Enter roll no of Student...");
            student.role1=System.Console.ReadLine()!;
            
            System.Console.WriteLine("Enter marks of sub1 of Student...");
            student.sub1=Convert.ToInt32(System.Console.ReadLine())!;
            
            System.Console.WriteLine("Enter marks of sub2 of Student...");
            student.sub2=Convert.ToInt32(System.Console.ReadLine())!;
            
            System.Console.WriteLine("Enter marks of sub3 of Student...");
            student.sub3=Convert.ToInt32(System.Console.ReadLine())!;

            System.Console.WriteLine($"Sum of marks of 3 subject is {student.sub1+student.sub2+student.sub3}");
    
        }
    }
}