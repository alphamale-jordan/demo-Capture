using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_Capture
{
    class Details : Form1
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        public Details(string name, string surname, int age, string gender, string city)

        {
          this.  FirstName = name;
          this.  LastName = surname;
          this.  Age = age;
           this. Gender = gender;
          this.  City = city;
        }
        public Details()
        {

        }
        
        

    }
}
