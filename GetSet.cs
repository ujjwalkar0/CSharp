namespace Program
{
    class GetSet
    {
        public DateTime birthday { get; private set; }

        public GetSet(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public int getAge
        {
            get
            {
                return DateTime.Today.Year - birthday.Year;
            }
        }
    }

    class newGetSet
    {
        private bool auth = false;
        private string clinisys = "Something";
        private string token = "abc";

        public string name
        {
            get
            {
                if (auth==true){
                    return clinisys;
                }
                return "None";
            }
            set
            {
                if (auth==true){
                    clinisys=value;
                }

            }
        }

        public newGetSet()
        {
            string val = Console.ReadLine()!;

            if (val==token){
                auth = true;
            }
        

            name = "Ujjwal";

            System.Console.WriteLine(name);
        }
    }
}