namespace Program{
    class parent{
        public void hello(){
            System.Console.WriteLine("Parent");
        }
    }

    class child: parent{
        public new void hello(){
            System.Console.WriteLine("Child");
        }
    }

    class methodHiding{
        public methodHiding(){
            child c = new child();
            c.hello();
        }
    }
}