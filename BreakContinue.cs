namespace Program
{
    class BreakContinue
    {
        public BreakContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);

                if (i == 6)
                {
                    break;
                }
                Console.WriteLine(i);

            }
        }
    }
}