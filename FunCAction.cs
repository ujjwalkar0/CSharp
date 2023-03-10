namespace Program
{
    class MyFunCAction
    {

        int sum(params int[] arr)
        {
            int i = 0;

            foreach (int j in arr)
            {
                i += j;
            }

            return i;

        }

       void printArr(params int[] arr)
        {
            System.Console.WriteLine(string.Join(", ", arr));
        }

        string dt(){
            // DateTime T = new DateTime();
            return Convert.ToString(DateTime.Now);
        }

        public MyFunCAction()
        {
            Func<int[], int> f = sum;
            System.Console.WriteLine(f.Invoke(new int[]{4,3,6,7,2}));

            Func<string> a = () => Convert.ToString(DateTime.Now);

            Action<int[]> d = printArr;
            d.Invoke(new int[]{3, 4, 8, 0, 9, 5, 7});

        }
    }
}