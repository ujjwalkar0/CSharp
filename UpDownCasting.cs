namespace Program
{
    class Animal
    {
        public string hello = "Animal can walk...";
        public virtual void walk()
        {
            System.Console.WriteLine(hello);
        }
    }

    class Dog : Animal
    {
        public new string hello = "Dog can also walk";
        public override void walk()
        {
            System.Console.WriteLine(hello);
        }
    }
    class UpDownCasting
    {
        public UpDownCasting()
        {   
            // Upcasting ...
            Animal a = new Dog();
            a.walk();
            System.Console.WriteLine(a.hello);
        }
    }
}