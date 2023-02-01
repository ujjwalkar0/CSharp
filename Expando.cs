using System.Dynamic;

namespace Program
{
    class MyExpando
    {
        public MyExpando()
        {
            dynamic expObj = new ExpandoObject();
            expObj.FirstName = "Ujjwal";
            expObj.LastName = "Kar";

            expObj.Contact = new ExpandoObject();
            expObj.Contact.Email = "ujjwalkar21@gmail.com";
            expObj.Contact.PhoneNo = 8388823359;

            // System.Console.WriteLine(expObj);

            foreach (KeyValuePair<string, dynamic> kvp in expObj)
            {
                if (kvp.Value.GetType().ToString() == "System.String")
                {
                    Console.WriteLine(kvp.Key + ": " + kvp.Value);
                }
                else if (kvp.Value.GetType().ToString() == "System.Dynamic.ExpandoObject")
                {

                    foreach (KeyValuePair<string, object> kvp1 in kvp.Value)
                    {
                        if (kvp1.Key.GetType().ToString() == "System.String")
                        {
                            Console.WriteLine(kvp1.Key + ": " + kvp1.Value);
                        }
                    }
                }

            }

        }
    }
}