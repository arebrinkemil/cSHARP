using System;
using System.Collections.Generic;

namespace Anstalldupg
{
  /*/ class Test
    {
        List<Anstalld> anställda;
        public Test()
        {
          anställda = new List<Anstalld>();
          Provision ada = new Provision("Ada", 5, 200000);
          anställda.Add(ada);
          anställda.Add(new Fastanställd("Kalle", 22000));

        }
        public void Run()
        {
          foreach( Anstalld gobbe in anställda)
          {
              
              Console.WriteLine(gobbe.ToString());
          }
        }
    }/*/

    class Test
    {
        private List<Anstalld> anställda = new List<Anstalld>();
        

        public void Run()
        {
            anställda.Add(new Provision("Ada", 6, 200000));
            
            
            anställda.Add(new Fastanställd("Kalle", 22000));


            anställda.Add(new Timanställd("Gurra", 120, 100));

           // anställda.Add(new BasOchProv("Beda", 8, 150000, 10000));

            foreach (Anstalld anstalld in anställda)
            {
               
                Console.WriteLine(anstalld.ToString());
                Console.WriteLine("");
            }
        }
    }


}



