namespace Program
{
    delegate int NumberChanger(int n);

    class MyDelegates
    {
        static int num = 10;

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
                return a+10;
            };

            System.Console.WriteLine(nm1.Invoke(8));


            NumberChanger nm = (a) =>
            {
                return a+10;
            };

            System.Console.WriteLine(nm.Invoke(8));

        }
    }
}