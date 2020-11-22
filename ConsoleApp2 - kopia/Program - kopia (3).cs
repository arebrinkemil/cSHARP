using System;
using System.Collections.Generic;

namespace UppgiftAnställd
{

    abstract class Anställd
    {
        protected String namn;

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

        public abstract double BeräknaLön();

        public override String ToString()
        {
            return namn + Environment.NewLine + BeräknaLön();
        }

    }

    class Timanställd : Anställd
    {
        private double timlön;

        private double arbetadeTimmar;

        public Timanställd(String namnet, double timlönen, double timmar) :base(namnet)
        {
            timlön = timlönen;
            arbetadeTimmar = timmar;
        }

        public override double BeräknaLön()
        {
            return timlön * arbetadeTimmar;
        }

        public override String ToString()
        {
            return base.ToString() + " = Månadslön"+ Environment.NewLine +  "Timlön: " + timlön + Environment.NewLine + "Arbetade timmar: " + arbetadeTimmar;
        }
    }


    class Provisionsanställd : Anställd
    {
        protected double Provision;

        protected double Försäljning;

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
            return base.ToString()+ " = Månadslön" + Environment.NewLine + "Provision: " + Provision + Environment.NewLine + "Försäljning: " + Försäljning; 
            
        }
    }

    class Fastanställd : Anställd
    {
        private double månadslön;

        public Fastanställd(String namnet, double lön) : base(namnet)
        {
            månadslön = lön;
        }

        public override double BeräknaLön()
        {
            return månadslön;
        }

        public override string ToString()
        {
            return base.ToString() + " = Månadslön";
        }
    }

     class BasOchProvisionsanställd : Provisionsanställd
    {
        private double fastLön;

        public BasOchProvisionsanställd(String namnet, double provision, double försäljning, double lön) : base(namnet,provision,försäljning)
        {
            fastLön = lön;
        }

        public override double BeräknaLön()
        {
            return ((Provision/100) * Försäljning) + fastLön; 
        }

        public override String ToString()
        {
            return base.ToString() + Environment.NewLine + "Fast lön: " + fastLön;
        }
    }
}