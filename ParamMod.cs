namespace Program
{
    class ParamMod
    {
        // ref
        void addTen(ref int s)
        {
            s += 10;
        }

        // out
        void testOut(int a, out int b, out double c)
        {
            b = a * a;
            c = Math.Sqrt(a);
        }

        // in
        void testIn(in int m)
        {
            // m = 9;  // rise an error as it is readonly.
        }

        // params
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            // foreach loop
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }

        public ParamMod()
        {
            int a = 5;
            addTen(ref a);
            System.Console.WriteLine(a);

            int sq; double sqrt;
            testOut(a, out sq, out sqrt);

            System.Console.WriteLine(sq);
            System.Console.WriteLine(sqrt);

            testIn(a);
            
            System.Console.WriteLine(Add(12,13,10,15,56));

        }
    }
}