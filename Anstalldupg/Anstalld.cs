using System;

namespace Anstalldupg
{
    class Anstalld
    {
        private String namn;

     
        
        public Anstalld(String namn)
        {
            this.namn = namn;

        }
        public virtual double BeräknaLön()
        {
            return 0;

        }
        public override String ToString()
        {
            return namn;
        }
        
    }
}
