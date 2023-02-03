namespace Program
{
    class MyEvents
    {
        public delegate int PrintWord(int value);
        public event PrintWord? MyEvent;
        public MyEvents()
        {
            Hello();
        }

        public PrintWord Hello()
        {
            System.Console.WriteLine("Hello World");
            // PrintWord p = new PrintWord(printValue);

            MyEvent = printValue;
            MyEvent(8);
            
            return MyEvent;
        }
        
        public int printValue(int n)
        {
            System.Console.WriteLine($"Number is: {n}");
            return 0;
        }

    }
}