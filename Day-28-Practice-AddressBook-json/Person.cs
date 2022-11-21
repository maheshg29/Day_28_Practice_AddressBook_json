using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_28_Practice_AddressBook_json
{
   public class Person
    {
            public string FName;
            public string LName;
            public string Address;
            public long PhoneNumber;

            public string Result()
            {
                return "Name is: " + FName + " " + LName + "\n Address: " + Address + "\n Phone: " + PhoneNumber;
            }
        
    }
}
