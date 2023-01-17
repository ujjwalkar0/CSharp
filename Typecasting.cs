namespace Program
{
    class Typecasting
    {
        public Typecasting()
        {
            /*
                In C#, there are two types of casting

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
            
            */
            int a = 'c'; // implicit casting;

            int b = (int)9.3;   // explicit casting

            // non compatible
            // int n = (int)"9"; // error

            int n = Convert.ToInt32("68975");   // allow null value
                                                // int allowBlank = Convert.ToInt32("");

            int m = Int32.Parse("68975");       // don't allow null value
            // int notAllowBlank = Int32.Parse("");

            System.Console.WriteLine("{0}", a);
            System.Console.WriteLine(b + " " + n + " " + m);

            // System.Console.WriteLine(allowBlank + " " + notAllowBlank);


        }
    }
}