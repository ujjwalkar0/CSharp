namespace Program
{
    class MyAssyncAwait
    {
        public async void Method1()
        {
            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Method 1 is running...");
                await Task.Delay(1000);
            }
        }

        public void Method2()
        {
            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Method 2 is running...");
                
            }
        }

        public async void Method3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 4; i++)
                {
                    System.Console.WriteLine("Method 3 is running...");
                    Thread.Sleep(4000);
                }
            });
            Environment.Exit(0);
        }

        public MyAssyncAwait()
        {
            Method1();
            Method2();
            Method3();
            System.Console.ReadLine();
        }
    }
}