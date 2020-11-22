using System;
using System.Collections.Generic;

namespace UppgiftAnställd
{
    

     class Test
    {
        private List<Anställd> anställda = new List<Anställd>();
        

        public void Run()
        {
            anställda.Add(new Provisionsanställd("Benge", 14, 200000));
            

            foreach (Anställd anstalld in anställda)
            {
               
                Console.WriteLine(anstalld.ToString());
                Console.WriteLine("");
            }
        }
    }


    class Program
    {

        
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Run();

          } 
    }
}