namespace Program
{
    class MyArrays
    {
        public MyArrays()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine(cars[0]);
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            // string s = "ujjwal";
            // s = "abc";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            System.Console.WriteLine();
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            System.Console.WriteLine();
            Array.Sort(cars);

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}