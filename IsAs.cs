namespace Program
{
    class IsAs
    {
        void check(object a)
        {
            if (a is int)
            {
                System.Console.WriteLine($"{a} is an Integer");
            }
            else if (a is string)
            {
                System.Console.WriteLine($"{a} is an String");
            }
        }

        public IsAs()
        {
            object a = 533;
            check(a);

            string? c = a as string;
            check(c!);

            object m = "hello";
            string? n = m as string;
            check(n!);

        }
    }
}