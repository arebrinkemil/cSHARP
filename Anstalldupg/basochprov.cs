using System;

namespace Anstalldupg
{
    class BasOchProv : Provision
    {
        private double fastLön;

        public Provision(string namnet, double provision, double försäljning, double lön):base(namnet,provision,försäljning)
       {
           fastLön = lön;

       }
       public override double BeräknaLön()
       {
           return  ((provision / 100) * försäljning) + fastLön;

       }
       public override String ToString()
       {
           return "Ada: " + 
                Environment.NewLine + "provisionsanställd" + 
                Environment.NewLine + "provision: " +provision + 
                Environment.NewLine + "försäljning:" +försäljning + 
                Environment.NewLine + "lön:" + BeräknaLön();

       }
    }
}
