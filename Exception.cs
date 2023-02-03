namespace Program
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }

    class MyException
    {
        public MyException()
        {
            try
            {
                System.Console.WriteLine("{0} {1}", 5);
            }
            catch (System.FormatException e1)
            {
                System.Console.WriteLine(e1.Message);
            }
            finally
            {
                System.Console.WriteLine("Done..");
            }
            
            Console.ReadKey();

            int n = Convert.ToInt16(Console.ReadLine());
            try
            {
                if (n < 18)
                {
                    throw new InvalidAgeException("Not eligible for vote...");
                }
            }
            catch (InvalidAgeException agemsg)
            {
                System.Console.WriteLine(agemsg);
            }
            
            Console.ReadKey();
            
            int[] arr = new int[3];

            try
            {
                arr[4] = 5;
            }
            catch(IndexOutOfRangeException e){
                System.Console.WriteLine(e.Message);
            }

        }
    }
}