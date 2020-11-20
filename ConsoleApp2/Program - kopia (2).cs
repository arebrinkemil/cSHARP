using System;
using System.Collections.Generic;

namespace UppgiftAnställd
{
    class UserInterfaces
    {
        static Personalhanterare ph = new Personalhanterare();

        public void Run(){
            PrintMenu();
            String svar = Console.ReadLine();
            while (svar != "a")
            {
                if (svar == "1")
                {
                    Console.WriteLine("");
                    ph.LäggTillAnställd();
                    Console.WriteLine("");                }

                else if (svar =="2")
                {
                   Console.WriteLine(""); 
                   ph.PrintAnställd(); 
                }

                else if (svar =="3")
                {
                    Console.WriteLine("");
                    ph.Printnamnet();
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Fel inmatning!");
                }

                PrintMenu();
                svar = Console.ReadLine();
            
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("Välkommen");
            Console.WriteLine("1. Lägg till en ny anställd");
            Console.WriteLine("2. Skriv ut uppgifter om alla anställda");
            Console.WriteLine("3. Skriv ut namn på alla anställda");
            Console.WriteLine("a. Avsluta");
        }
    }

     class Test
    {
        private List<Anställd> anställda = new List<Anställd>();
        

        public void Run()
        {
            anställda.Add(new Provisionsanställd("Ada", 6, 200000));
            anställda.Add(new Timanställd("Gurra", 120, 35));
            anställda.Add(new BasOchProvisionsanställd("Beda", 8, 150000, 10000));
            anställda.Add(new Fastanställd("Kalle", 22000));

            foreach (Anställd anstalld in anställda)
            {
                Console.WriteLine(anstalld.GetType().Name);
                Console.WriteLine("");
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

            UserInterfaces ui = new UserInterfaces();
            ui.Run();
        }
    }
}