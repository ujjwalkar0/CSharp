namespace Program
{
    class Modifier
    {
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

        public Modifier()
        {
            System.Console.WriteLine(Add(12,13,10,15,56));
        }
    }
}