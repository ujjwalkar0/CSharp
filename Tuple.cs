namespace Program
{
    class MyTupple
    {
        (int, int) Sum((int, int) a)
        {
            return (0, a.Item1+a.Item2);
        }
        public MyTupple()
        {
            // Tuple
            System.Console.WriteLine("----: Normal Tuple :-----");
            System.Console.WriteLine("Enter your name and age seperated by Coma..");
            string[] sc = Console.ReadLine()!.Split(",");

            if (sc.Length >= 2)
            {
                Tuple<string, int> tup = Tuple.Create(sc[0], Convert.ToInt32(sc[1]));
                System.Console.Write($"Hello {tup.Item1}");
                System.Console.WriteLine(tup.Item2 > 18 ? $" You are eligible for vote..." : "you are not eligible for vote...");
            }


            System.Console.ReadKey();

            // Value type tuple
            System.Console.WriteLine("-------------: Value type tuple in C# :--------------");
            (double, int) t1 = (4.5, 3);
            Sum(t1);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            t1.Item1 = 5.8;
            t1.Item2 = 9;
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");


            // (string, int) tup1 = (sc[0], Convert.ToInt32(sc[1]));


            // Named tuple
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            Console.WriteLine($"Hash code of {t1} is {t1.GetHashCode()}.");

            System.Console.ReadKey();
            // ALL
            var t = (2, 3, 5, 7, 8, 4, 5, 6, 3, 2, 1, 9, 4, 5);

            System.Console.WriteLine(t);

            var t3 = (Sum: 4.5, Count: 3);
            Console.WriteLine($"Sum of {t3.Count} elements is {t3.Sum}.");

            (double Sum, int Count) d = (4.5, 3);
            Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

            var sum = 4.5;
            var count = 3;
            var t4 = (sum, count);
            Console.WriteLine($"Sum of {t4.count} elements is {t4.sum}.");

            var a = 1;
            var t5 = (a, b: 2, 3);
            Console.WriteLine($"The 1st element is {t5.Item1} (same as {t5.a}).");
            Console.WriteLine($"The 2nd element is {t5.Item2} (same as {t5.b}).");
            Console.WriteLine($"The 3rd element is {t5.Item3}.");


        }
    }
}