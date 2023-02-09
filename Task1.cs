// define an array in annonomous way and sort it.

namespace Program
{
    class Task1
    {
        public Task1()
        {
            string sc = System.Console.ReadLine()!;
            int[] a = sc.Split(",").Select(int.Parse).ToArray();
            // var annArr = new[] {1, 4, 5, 3, 2, 8};
            
            Array.Sort(a);

            foreach(int i in a){
                System.Console.WriteLine(i);
            }

        }
    }
}