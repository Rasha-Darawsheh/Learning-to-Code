using Bank_of_Questions;

internal class Program
{
    private static void Main(string[] args)
    {
        Questions Q1 = new Questions();
        Q1.SetQuestionsText("what is 5*5");

        Q1.AddOptions("25");
        Q1.AddOptions("20");
        Q1.AddOptions("26");
        Q1.AddOptions("35");
        Q1.AddOptions("37");

        Q1.SetCorrectAnswer("25");

        Q1.PrintQuestionsText();
        Console.WriteLine($"options: \n");

        int count = 1;
        foreach (string item in Q1.Options)
        {
            Console.WriteLine(count++ + " " + item);
        }

        Console.WriteLine("Please enter the correct answer  ");

        string answerString = Console.ReadLine();
        if (Q1.CorrectAnswer == answerString)
        {
            Console.WriteLine("CorrectAnswer");
        }
        else
        {
            for (int i = 0; i < Q1.Options.Count; i++)
            {
                if (int.TryParse(answerString, out int answerInt))
                {
                    int indexOfUserAnswer = (answerInt - 1);

                    if (indexOfUserAnswer == i)
                    {
                        if (Q1.Options[i] == Q1.CorrectAnswer)
                        {
                            Console.WriteLine("Correct Answer");
                        }
                    }
                }
            }
        }

    }

}   