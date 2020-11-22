using System;
using System.Collections.Generic;

namespace UppgiftAnställd
{

    class Anställd
    {
       private String namn;

        public String Namn
        {
            get
            {
                return namn;
            }
        }

        public Anställd(String namnet)
        {
            namn = namnet;
        }

        public double BeräknaLön();

        public override String ToString()
        {
            return namn + Environment.NewLine + BeräknaLön();
        }

    }

 

    class Provisionsanställd : Anställd
    {
        private double Provision;

        private double Försäljning;

        public Provisionsanställd(String namnet, double provision, double försäljning) : base(namnet)
        {
            Provision = provision;
            Försäljning = försäljning;

        }

        public override double BeräknaLön()
        {
            return (Provision/100) * Försäljning;
        }

        public override String ToString()
        {
            return "Provisions anställd" + Environment.NewLine + base.ToString()+ " = Månadslön" + Environment.NewLine + "Provision: " + Provision + Environment.NewLine + "Försäljning: " + Försäljning; 
            
        }
    }


}