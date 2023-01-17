namespace Program
{
    class While
    {
        public While()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            System.Console.WriteLine("Let's do while...");
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 20);


        }
    }
}