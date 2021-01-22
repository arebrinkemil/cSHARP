using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDemoNestedStackPanel
{
    abstract class Questions12
    {
        protected String question;

        protected String answer;


        public string Question
        {
        get {
                return question;

            }
        }

        public string Answer
        {
            get
            {
                return answer;

            }
        }


        public void GetAnswer(Questions12 svaret)
        {
            String SVAR = Console.ReadLine();
            if (SVAR == svaret.answer)
            {
                Console.WriteLine("Rätt!");
            }

            else
            {
                Console.WriteLine("Fel!");
            }

        }
        abstract public void Skrivut();
    }


   
    



    class QuestionText : Questions12
    {

        public QuestionText(String q1, String q2)
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

