namespace Program
{
    class SomeClass
    {
        public int A_no;
        public string? Aname;
        public string? language;
        public int age;
    }

    class annonTypes
    {
        public annonTypes()
        {
            // Annonomous type
            var a = new
            {
                n = 5,
                hello = "abc",
                arr = new
                {
                    me = "Ujjwal"
                }

            };

            System.Console.WriteLine(a.n);
            System.Console.WriteLine(a.hello);
            System.Console.WriteLine(a.arr.me);
            System.Console.WriteLine(a.GetType());

            // List of annonomous class
            List<SomeClass> g = new List<SomeClass>
            {
                new SomeClass{ A_no = 123, Aname = "Shilpa",
                            language = "C#", age = 23 },
                new SomeClass{ A_no = 124, Aname = "Shilpi",
                            language = "C#", age = 20 },
                new SomeClass{ A_no = 125, Aname = "Soniya",
                            language = "C#", age = 22 },
                new SomeClass{ A_no = 126, Aname = "Sonaly",
                            language = "C#", age = 25 },
            };

            var anony_ob = from geek in g select new { geek.A_no, geek.Aname, geek.language };
            foreach (var i in anony_ob)
            {
                Console.WriteLine($"Author id = {i.A_no} \nAuthor name = {i.Aname} + \nLanguage = {i.language}");
                Console.WriteLine();
            }


            var annArr = new[] {
                new {
                    hello = "Hello",
                    a = 44,
                    o = "nbknkbjnkbgj"
                },
                new {
                    hello = "bjhfbjhb",
                    a = 44774,
                    o = "nbcnvnknkbjnkbgj"
                },
            };

            System.Console.WriteLine(annArr.GetType());
            System.Console.WriteLine(annArr.GetLength(0));
        }
    }
}