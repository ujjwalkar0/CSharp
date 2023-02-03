namespace Program{
    class MyStruct{

        struct OK
        {
            public OK(int h){
                System.Console.WriteLine(h);
            }
        }

        public MyStruct(){
            OK o = new OK(5);
        }
    }
}