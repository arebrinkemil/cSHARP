using System;
using System.Collections.Generic;

namespace Questions
{


      class QuestionChoice : Questions12
    {
        String F1;
        String F2;
        String F3;
        public QuestionChoice( String pq, String pa, String pa1, String pa2, String pa3)
        {
            question = pq;
            answer = pa;
            F1 = pa1;
            F2 = pa2;
            F3 = pa3;
           
        }

        public override void Skrivut()
        {
            Console.WriteLine(question);
            Console.WriteLine("");
            Console.WriteLine("1. " + F1);
            Console.WriteLine("");
            Console.WriteLine("X. " + F2);
            Console.WriteLine("");
            Console.WriteLine("2. " + F3);
            Console.WriteLine("");
   
            
        }
    }



        class QuestionText : Questions12
    {

        public QuestionText( String q1, String q2)
        {
            question = q1;
            answer = q2;
        }

        public override void Skrivut()
        {
            Console.WriteLine(question);
        }
    }







  

}




