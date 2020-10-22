using System;

  class Program
  {
      static void Main(string[] args)
      {
      }    
          

      static void Uppgift_1A()
      {
          svar = Console.ReadLine();
               if (svar = "q")
               {
                   Console.WriteLine("slut");
               }
               else
               {
          // lösning till uppgiften här
         Console.WriteLine("Hej Ada! Varmt Välkommen.");
            Console.WriteLine();

      }

      static void Uppgift_1B()
      {
          // lösning till uppgiften här
          double bredd = 9.6;
            double höjd = 5.4;
            double area;
            area = bredd * höjd / 2;
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
      }

      static void Uppgift_1c()
      {
            Console.WriteLine("Räkna ut area av Triangel");
            Console.WriteLine("Bredd?");
            String value1 = Console.ReadLine();
            Console.WriteLine("Höjd?");
            String value2 = Console.ReadLine();
            double area;
            double decimaltal1 = Convert.ToDouble(value1);
            double decimaltal2 = Convert.ToDouble(value2);
            area = decimaltal1 * decimaltal2 / 2;
            Console.WriteLine("Triangels area=" + area);
      } 

      static void Uppgift_1d()
      {
          Console.WriteLine("Addera två nummer:");
          String nmr1 = Console.ReadLine();
          String nmr2 = Console.ReadLine();
          int tal1 = Convert.ToInt32(nmr1);
          int tal2 = Convert.ToInt32(nmr2);
          int summa;
          summa = tal1 + tal2;
          Console.WriteLine("Summan=" + summa);

      }

      static void Uppgift_2a()
      {
          Console.WriteLine("Gissa mitt favvo nummer!!!!");
          string talet = Console.ReadLine();
          int tal2 = Convert.ToInt32(talet);
          if (tal2 == 3)
          {
              Console.WriteLine("Rätt!!");
          }
          else
          {
              Console.WriteLine("FEL");
          }
      }

      static void Uppgift_2b()
      {
          Random rG1 = new Random();
          Random rG2 = new Random();
          int aö1 = rG1.Next(1, 7);
          Console.WriteLine(aö1);
          int aö2 = rG2.Next(1, 7);
          Console.WriteLine(aö2);
          if(aö1 == aö2)
          {
              Console.WriteLine("SAMMA");
          }
          else{
              Console.WriteLine("Olika");
          }

      }

      static void Uppgift_3a()
      {
           int count = 1;
            while (count < 6)
            {
                Console.WriteLine("" + count);
                count = count + 1;
            }
            

      }

      static void Uppgift_3b()
      {
            int count = 5;
            while (count < 21)
            {
                Console.WriteLine("" + count);
                count = count + 3;
            }

      }

      static void Uppgift_3c()
      {
             int count = 10;
            while (count > -1)
            {
                Console.WriteLine("" + count);
                count = count - 1;
            }
            

      }

      static void Uppgift_4a()
      {
          for (int i = 1; i < 6; i = i + 1)
            {
                Console.WriteLine("" + i);
            }
      }

      static void Uppgift_4b()
      {
          for (int i = 5; i < 21; i = i + 3)
            {
                Console.WriteLine("" + i);
            }

      }

      static void Uppgift_4c()
      {
        for (int i = 10; i > -1; i = i - 1)
            {
                Console.WriteLine("" + i);
            }
      }

      static void Uppgift_5()
      {
          String input = "14";
            while (!input.Equals("15")) 
            {
                Console.WriteLine("Gissa nummret!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Rätt");
            Console.WriteLine();
    
      }

      static void Uppgift_6()
      {
          Random rG1 = new Random();
          Random rG2 = new Random();
          int aö1 = rG1.Next(1, 7);
          Console.WriteLine(aö1);
          int aö2 = rG2.Next(1, 7);
          Console.WriteLine(aö2);
          if (aö1 * aö2 == 36)
          {
            Console.WriteLine("Grattis du fick storvinst");
          }
          else if (aö1 == aö2)
          {
            Console.WriteLine("Du vann ett litet pris");
          }
          else
          {
              Console.WriteLine("Förlust");
          }

      }

      static void Uppgift_7()
      {
          int[] tal = new int[6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;

      }

      static void uppgift_8()
      {
          int[] tal = new int[6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;
            
            foreach(int talet in tal)
            {
                Console.Write(talet + ",");
            }
            Console.WriteLine();

      }

      static void uppgift_8b()
      {
           int[] tal = new int[6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;
            

           for (int runs=0; runs < 6; runs++)
           {
               tal[runs]= tal[runs] + 1;
           }
           Console.WriteLine(tal[0]);
           Console.WriteLine(tal[1]);
           Console.WriteLine(tal[2]);
           Console.WriteLine(tal[3]);
           Console.WriteLine(tal[4]);
           Console.WriteLine(tal[5]);

      }

      
        
        static void  uppgift_9a()
        {
          Console.WriteLine("Välkommen Agent X. Ditt uppdrag är ...");

        }



       static void uppgift_9c()
       {
        Console.WriteLine("Addera tre nummer:");
          String nmr1 = Console.ReadLine();
          String nmr2 = Console.ReadLine()2;
            String nmr3 = Console.ReadLine();
            int tal1 = Convert.ToInt32(nmr1);
          int tal2 = Convert.ToInt32(nmr2);
          int tal3 = Convert.ToInt32(nmr3);
          int summa;
          int summa2;
          summa = Addera(tal1 , tal2);
          summa2= Addera2(summa , tal3);
          Console.WriteLine("Summan=" + summa2);
       }

       static int Addera(int tal1, int tal2)
       {
           return tal1 + tal2;
       }

       static int Addera2(int summa, int tal3)
       {
           return summa + tal3;
       }


       static void uppgift_10()
       {
           string[] produkter = new string[20];
            int svar;
            int antal = 0;
            Console.WriteLine("Shopping lista");
            while(true)
            {     
               
                Console.WriteLine("\n1. Lägg till produkt\n2. Skriva ut lista");
			    svar = Convert.ToInt32(Console.ReadLine());
                if (svar == 1)
                {

                    string mat = Console.ReadLine();
                    produkter[antal] = mat;
                    antal = antal + 1;
                }
            
                else if (svar == 2)
                {
                    foreach(string talet in produkter)
                    {
                        Console.Write(talet + " ");

                    }
                Console.WriteLine();
                break;
                }

            }

       }


      }



  }
