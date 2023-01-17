namespace Program{
    class Conditions{
        public Conditions(){
            Console.Write("Enter a number... : ");
            int n = Convert.ToInt16(Console.ReadLine());

            if (n>10){
                System.Console.WriteLine("Number is greater than 10");
            }
            else if (n==10){
                System.Console.WriteLine("Number is equal to 10");
            }
            else{
                System.Console.WriteLine("Number is less than 10");
            }
        }
    }
}