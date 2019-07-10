using System;
using System.Collections.Generic;

namespace family_affair
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Dictionary that contains information about several members of your family

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mother", new Dictionary<string, string>(){
            {"name", "Morticia"},
            {"age", "142"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){
            {"name", "Gomez"},
            {"age", "146"}
            });

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Wednesday"},
            {"age", "12"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Pugsley"},
            {"age", "11"}
            });

            // Next, iterate over each item in myFamily and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                // ... your code here

                var member = familyMember.Key;
                var age = familyMember.Value["age"];
                var name = familyMember.Value["name"];
                Console.WriteLine($"{name} is my {member} and is {age} years old.");
                // example output: Krista is my sister and is 42 years old
            }
        }

    }
}
