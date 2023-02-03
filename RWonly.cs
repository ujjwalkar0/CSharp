namespace Program
{
    class RWonly
    {
        readonly int n = 10;
        public RWonly()
        {
            // readonly int m = 100;  readonly not work inside methode, constructor...

            System.Console.WriteLine(n+m);
        }
        readonly int m = 10;
        // void ReadOnly(){
        //     public readonly int m = 49;
        // }
    }
}