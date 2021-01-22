using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfFordon
{
    class Vehicle
    {

        private string regnr;
        private string namn;



        public Vehicle(string nummer, string kallelse)
        {

            regnr = nummer;
            namn = kallelse;
        }

        public override String ToString()
        {

            return Environment.NewLine + "Registreringsnummer : " + regnr + Environment.NewLine + "Namn : " + namn + Environment.NewLine;
        }
        // registratoin number
        // owner


        // konstruktor tar registeringsnummer som parameter
        // bara registreringsnummer

        // property för att läsa registreringsnummer

        // property för att läsa och sätta ägare
    }
}
