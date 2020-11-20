using System;
using System.Collections.Generic;

namespace UppgiftAnställd
{
    class Personalhanterare
    {
       protected List<Anställd> deanställda = new List<Anställd>();

       public void LäggTillAnställd()
       {
           Console.WriteLine("");
           Console.WriteLine("Välj typ av anställd");
           Console.WriteLine("1. Fastanställd");
           Console.WriteLine("2. Provisionsanställd");
           Console.WriteLine("3. Bas och Provisionsanställd");
           Console.WriteLine("4. Timanställd");
           Console.WriteLine("a. Avsluta");
           String val = Console.ReadLine();

           if (val == "1")
           {
               Console.WriteLine("");
               Console.WriteLine("Namn: ");
               String namn = Console.ReadLine();
               Console.WriteLine("Månadslön: ");
               String lönen = Console.ReadLine();
               deanställda.Add(new Fastanställd(namn, Convert.ToDouble(lönen)));
           }

           else if (val =="2")
           {
               Console.WriteLine("");
               Console.WriteLine("Namn: ");
               String namn = Console.ReadLine();
               Console.WriteLine("Provision(%): ");
               String provision = Console.ReadLine();
               Console.WriteLine("Försäljning: ");
               String forsaljning = Console.ReadLine();
               deanställda.Add(new Provisionsanställd(namn, Convert.ToDouble(provision), Convert.ToDouble(forsaljning)));
            }

            else if (val =="3")
            {
                Console.WriteLine("");
                Console.WriteLine("Namn: ");
                String namn = Console.ReadLine();
                Console.WriteLine("Provision: ");
                String provision = Console.ReadLine();
                Console.WriteLine("Försäljning: ");
                String forsaljning = Console.ReadLine();
                Console.WriteLine("Lön: ");
                String lönen = Console.ReadLine();
                deanställda.Add(new BasOchProvisionsanställd(namn, Convert.ToDouble(provision), Convert.ToDouble(forsaljning), Convert.ToDouble(lönen)));



            }

            else if (val =="4")
            {
                Console.WriteLine("");
                Console.WriteLine("Namn: ");
                String namn = Console.ReadLine();
                Console.WriteLine("Timlön: ");
                String timlon = Console.ReadLine();
                Console.WriteLine("Arbetade timmar: ");
                String timmarna = Console.ReadLine();
                deanställda.Add(new Timanställd(namn, Convert.ToDouble(timlon), Convert.ToDouble(timmarna)));

            }

            else
            {
                Console.WriteLine("Fel syntax");
                LäggTillAnställd();
                
            }

       }

       public void PrintAnställd()
       {
           foreach (Anställd item in deanställda)
           {
               Console.WriteLine(item.ToString());
               Console.WriteLine("");
           }
       }

       public void Printnamnet()
       {
           foreach (Anställd info in deanställda)
           {
               Console.WriteLine(info.Namn);
           }
       }
    }
}