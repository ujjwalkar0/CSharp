namespace Program
{
    class Goto
    {
        public Goto()
        {
            int x = 1;
        Loop:
            System.Console.WriteLine(x);
            x++;

            if (x < 10)
            {
                goto Loop;
            }

            // Hello:
            //     System.Console.WriteLine("Hello World");
            // foreach(int i in new int[]{3, 5, 6}){
            //     goto Hello;
            // }

        }
    }
}