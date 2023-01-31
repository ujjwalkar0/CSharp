namespace Program{
    static class staticClass{

        public static int a = 9;
        static staticClass(){
            System.Console.WriteLine("Static Constructor...");
        }
    }

    class staticModifier{
        public static int n = 87;

        public int N{
            get{
                return n;
            }
            set{
                n = value;
            }
        }
    }
}