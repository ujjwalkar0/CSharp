namespace Program{
    partial class Hello{

        private static int n = 10;
        partial void abc(){
            System.Console.WriteLine("Hello from abc...");
        }

        // partial int MyHello();
        void HelloWorld(){
            System.Console.WriteLine("Hello World");
        }
        // int[] abc = new int[5];
        // int this[int key]{
        //     get{
        //         return abc[key];
        //     }
        //     set{
        //         abc[key] = value;
        //     }
        }
        class Partial{
            public Partial(){
                Hello.CallPrivate();
            }
        }
    }
