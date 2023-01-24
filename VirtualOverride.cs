namespace Program
{
    public class Base
    {
        public virtual void Test()
        {
            Console.WriteLine("Base...");
        }
    }
    public class Derived : Base
    {
        public override void Test()
        {
            Console.WriteLine("Derived...");
        }

        public Derived(){
            Test();
        }
    }
}