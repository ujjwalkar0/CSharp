namespace Program
{
    class MyDynamic
    {

        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        public MyDynamic()
        {
            dynamic a = 9;

            a = Convert.ToString(a);
            System.Console.WriteLine(a);

            dynamic b = new List<Int32>();
            var c = b;
            b.Add(8);
            b.Add(4);
            b.Add(3);
            b.Add(2);

            System.Console.WriteLine();

            foreach (Int32 i in b)
            {
                System.Console.Write(i);

            }
            System.Console.WriteLine();

            c.Add(85);
            c.Add(80);
            c.Add(75);

            foreach (Int32 i in c)
            {
                System.Console.Write(i);

            }
            System.Console.WriteLine();

            b = 8;

            foreach (Int32 i in c)
            {
                System.Console.Write(i);

            }
            System.Console.WriteLine();

            System.Console.WriteLine(Add("Hello", "World"));
            System.Console.WriteLine(Add("Hello", 8));
            System.Console.WriteLine(Add(8, 9));
        }
    }
}