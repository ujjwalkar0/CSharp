namespace Program
{
    class MyString
    {
        public MyString()
        {
            string greeting = "Hello";
            Console.WriteLine(greeting, greeting.Length);

            string firstName = "Ujjwal ";
            string lastName = "Kar";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);


            string name3 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name3);

            string myString = "Hello";
            Console.WriteLine(myString[0]);

            Console.WriteLine(myString.IndexOf("e"));


            int charPos = name.IndexOf("K");

            string lastName2 = name.Substring(charPos);

            Console.WriteLine(lastName2);


            string txt = "We are the so-called \"Vikings\" from the north.";

            System.Console.WriteLine(txt);

            string txt2 = "It\'s alright.";
            System.Console.WriteLine(txt2);

            string txt3 = "The character \\ is called backslash.";
            System.Console.WriteLine(txt3);

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            System.Console.WriteLine(letters);


            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            // Doubt
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            System.Console.WriteLine(waiting);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);


            string str1 = "C# Programming";
            string str2 = "C# Programming";
            string str3 = "Programiz";

            // compare str1 and str2
            Boolean result1 = str1.Equals(str2);
            Console.WriteLine("string str1 and str2 are equal: " + result1);

            //compare str1 and str3
            Boolean result2 = str1.Equals(str3);
            Console.WriteLine("string str1 and str3 are equal: " + result2);

            System.Console.WriteLine(str1 == str2);
            System.Console.WriteLine(str1 == str3);

        }
    }
}