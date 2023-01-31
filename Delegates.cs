namespace Program
{
    delegate int NumberChanger(int n);
    delegate void Test(int n);

    class MyDelegates
    {
        static int num = 10;

        public void Hello(int m)
        {
            m = m * 2;
            System.Console.WriteLine(m);
        }
        public void Hello1(int m)
        {
            m = m + 9;
            System.Console.WriteLine(m);
        }

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        public MyDelegates()
        {
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc = nc1;
            nc += nc2;

            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());

            NumberChanger nm1 = delegate (int a)
            {
                return a + 10;
            };

            System.Console.WriteLine(nm1.Invoke(8));


            NumberChanger nm = (a) =>
            {
                return a + 10;
            };

            System.Console.WriteLine(nm.Invoke(8));

            Test t = new Test(Hello);
            Test t1 = new Test(Hello1);

            Test t3 = t + t1;
            t3.Invoke(8);
        }
    }
}