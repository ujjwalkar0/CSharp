namespace Program
{
    class Datatypes
    {
        public Datatypes()
        {
            short sn = 8;               // 2 bytes, 16bit
            int n = 45;                 // 4 bytes, 32bit
            long ln = 8388823359L;      // 8 bytes, 64bit

            bool bn = true;             // 1 bit

            char c = 'c';               // 1 byte

            string s = "Hello World";   // Sequence of Char, 1byte each

            float f = 8.5F;             // 4 bytes
            double d = 8.5;             // 8 bytes

            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", sn, n, ln, bn, c, s, f, d);

        }
    }
}
