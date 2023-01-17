namespace Program
{
    interface FileManager
    {
        public void Create();
        public void Open();
    }

    interface authenticator{
        public bool authenticated(string username, string password);
    }

    class Oops : authenticator
    {
        private string username = "ujjwalkar";
        private string password = "123456";

        public bool authenticated(string username, string password)
        {
            if ((this.username == username) && (this.password == password))
            {
                return true;
            }
            return false;
        }

        public void Create(string username, string password)
        {
            if (this.authenticated(username, password)){
                System.Console.WriteLine("Enter a the name of the file...");
            }
            else{
                System.Console.WriteLine("Authentication Failed");
            }

        }
        public void Open()
        {

        }

        public Oops()
        {
            System.Console.Write("Username : ");
            string username = Console.ReadLine()!;

            System.Console.Write("Password : ");
            string password = Console.ReadLine()!;

            this.Create(username, password);
        }
    }
}