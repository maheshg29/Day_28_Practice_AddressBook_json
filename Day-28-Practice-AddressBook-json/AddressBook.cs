using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Day_28_Practice_AddressBook_json
{
       
        public class AddressBook
        {
            //Creating List 
            public List<Person> person = new List<Person>();

            //Person person1 = new Person();
            //Address Book method
            public AddressBook()
            {
                string json = File.ReadAllText(@"C:\Users\DELL\source\repos\DLS-RPF-213\Day-28-Practice-AddressBook-json\Day-28-Practice-AddressBook-json\jsconfig1.json");
                if (json.Length > 0)
                {
                    person = JsonConvert.DeserializeObject<List<Person>>(json);
                }
                else
                    person = new List<Person>();
            }

            //Display Method
            public void Display()
            {
                if (person.Count == 0)
                {
                    Console.WriteLine("Please add Some Contact list First");
                }
                Console.WriteLine("Welcome to Program");
                foreach (Person per in person)
                {
                    Console.WriteLine(per.Result());
                }
            }

            //Adding Contact list method
            public void addPerson(Person p)
            {
                person.Add(p);
                string jsonData = JsonConvert.SerializeObject(person);
                File.WriteAllText(@"C:\Users\DELL\source\repos\DLS-RPF-213\Day-28-Practice-AddressBook-json\Day-28-Practice-AddressBook-json\jsconfig1.json", jsonData);
            }
        }
    

}