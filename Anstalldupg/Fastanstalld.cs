using System;

namespace Anstalldupg
{
    class Fastanställd : Anstalld
    {
        private double månadslön;

        public Fastanställd(String namnet, double månadslön) : base(namnet)
        {
            this.månadslön = månadslön;
        }

        public override double BeräknaLön()
        {
            return månadslön;
        }

        public override string ToString()
        {
             return Environment.NewLine + base.ToString() +  
                    Environment.NewLine + "Fastanställd" +  
                    Environment.NewLine + "lön: " + BeräknaLön();
               
        }
    }
   
}
