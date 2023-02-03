namespace Program
{
    class sealedClass
    {
        public sealed class Hello
        {
            int ab = 5;
            public Hello()
            {
                System.Console.WriteLine(ab);
            }
        }
        // Sealed class is not inheritable...
        // public class Hi:Hello{
        // }
        class checkSealed
        {
            private int n = 10;
            public virtual int getNum()
            {
                return n;
            }
        }
        class checkFromHere : checkSealed
        {
            public override sealed int getNum()
            {
                return 0;
            }
        }
        public sealedClass(){
            checkSealed c = new checkSealed();
            System.Console.WriteLine(c.getNum());

            checkFromHere cf = new checkFromHere();
            System.Console.WriteLine(cf.getNum());
        }
    }
}