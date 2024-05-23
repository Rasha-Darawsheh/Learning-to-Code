using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Questions
{
    public class Questions
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; }

        public void SetQuestionsText(string value)
        {
            QuestionText = value;
        }
        public void PrintQuestionsText()
        {
            Console.WriteLine($"Question: {QuestionText}");
        }
        public void AddOptions(string options)
        {
            Options.Add(options);
        }
        public void SetCorrectAnswer(string answer)
        {
            foreach (string item in Options)
            {
                if (item == answer)
                {
                    CorrectAnswer = answer;
                    break;
                }
            }


        }
        public void PrintOptions()
        {
            int count = 0;
            foreach (string item in Options)
            {
                Console.WriteLine(count++ + " " + item);
            }


        }




    }

}
