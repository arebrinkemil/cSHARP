using System;

namespace Anstalldupg
{
    class Timanställd : Anstalld
    {
        private double timlön;

        private double arbetadeTimmar;

        public Timanställd(String namnet, double timlön, double arbetadeTimmar) :base(namnet)
        {
            this.timlön = timlön;
            this.arbetadeTimmar = arbetadeTimmar;
        }

        public override double BeräknaLön()
        {
            return timlön * arbetadeTimmar;
        }

        public override String ToString()
        {
           return Environment.NewLine + base.ToString() +  
                    Environment.NewLine + "Timanstalld" +  
                    Environment.NewLine + "timlön: " + timlön +
                    Environment.NewLine + "timmar: " + arbetadeTimmar +
                    Environment.NewLine + "lön: " + BeräknaLön();
        }
    }
}
