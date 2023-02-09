using System.Text.RegularExpressions;

namespace Program
{

    public class Person1 : IEquatable<Person1>
    {
        private string uniqueSsn;
        private string lName;

        public Person1(string lastName, string ssn)
        {
            if (Regex.IsMatch(ssn, @"\d{9}"))
                uniqueSsn = $"{ssn.Substring(0, 3)}-{ssn.Substring(3, 2)}-{ssn.Substring(5, 4)}";
            else if (Regex.IsMatch(ssn, @"\d{3}-\d{2}-\d{4}"))
                uniqueSsn = ssn;
            else
                throw new FormatException("The social security number has an invalid format.");

            this.LastName = lastName;
        }

        public string SSN
        {
            get { return this.uniqueSsn; }
        }

        public string LastName
        {
            get { return this.lName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("The last name cannot be null or empty.");
                else
                    this.lName = value;
            }
        }

        public bool Equals(Person1 other)
        {
            if (other == null)
                return false;

            if (this.uniqueSsn == other.uniqueSsn)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Person1 person1Obj = obj as Person1;
            if (person1Obj == null)
                return false;
            else
                return Equals(person1Obj);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode();
        }

        public static bool operator ==(Person1 person11, Person1 person12)
        {
            if (((object)person11) == null || ((object)person12) == null)
                return Object.Equals(person11, person12);

            return person11.Equals(person12);
        }

        public static bool operator !=(Person1 person11, Person1 person12)
        {
            if (((object)person11) == null || ((object)person12) == null)
                return !Object.Equals(person11, person12);

            return !(person11.Equals(person12));
        }
    }
    class MyIEquatable
    {
        public MyIEquatable()
        {

        }
    }
}