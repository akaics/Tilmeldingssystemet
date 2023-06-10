using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tilmeldingssystemet
{
    internal class Person
    {
        //Adding properties 
        private int id;
        private string name;
        private string adress;
        private string patrulje;
        private DateTime dateTime;
        private bool enUge;

        //Adding properties
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Patrulje { get; set; }
        public DateTime DateTime { get; set; }
        public bool EnUge { get; set; }

        //Adding constructors 

        public Person(int id, string name, string adress, string patrulje, DateTime datetime, bool enUge)
        {
        ID = id;
        Name = name;
        Adress = adress;
        Patrulje = patrulje; 
        DateTime = dateTime;
        EnUge = enUge;
        }

        //Adding a ToString method
        public override string ToString()
        {
            return  $"Person's info: {ID}, {Name}, {Adress}, {Patrulje}, {DateTime}, {EnUge}";
        }


    }

   
}

