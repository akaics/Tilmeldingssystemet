using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tilmeldingssystemet
{
    internal class Tilmeldingskatalog
    {
        //Adding properties

        private string lejrId;
        private bool ugeRegel;
        private DateTime startDato;
        private DateTime slutDato;

        // Adding getters and setters for properties 

        public string LejrId { get; set; }
        public bool UgeRegel { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        //Dictionary property:
        public Dictionary<int, Person> PersonDictionary { get; set; }


        // Adding constructors 

        public Tilmeldingskatalog(string lejrId, bool ugeRegel, DateTime startDato, DateTime slutDato) 
        {
            LejrId = lejrId;
            UgeRegel = ugeRegel;
            StartDato = startDato;
            SlutDato = slutDato;
            //Tilføjer dictionary
            PersonDictionary = new Dictionary<int, Person>();
        }

        //Adding a ToString method
        public override string ToString()
        {
            return $"Tilmeldingskatalog: {LejrId}, {UgeRegel}, {StartDato}, {SlutDato}";
        }

        //foreach (Person person in Person)
      
    }
}
