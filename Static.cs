namespace Program
{
    
    public static class MyHello
    {
        public static int a = 9;
        public static int Janina { get; set; }
    }
    class MyStatic
    {
        static void abc()
        {
            System.Console.WriteLine("Ok...");
        }
        public MyStatic()
        {
            System.Console.WriteLine(MyHello.a);
            MyHello.Janina = 99;
            System.Console.WriteLine(MyHello.Janina);
        }
    }
}