using System;

namespace Idea_Generator
{
    class Program
    {
        static string Output(string text)
        {
            string outpot = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;

            return outpot;
        }
        static void Gen(string[] Dict)
        {
            string text = "";
            Random rand = new Random();
            for (int I = 0; I < 10; I++)
            {
                for (int J = 0; J < 5; J++)
                {
                    text = text + Dict[rand.Next(0, Dict.Length)] + " ";
                }
                Output(text);
                text = "";
            }
            Ret(Dict);
        }
        static void Ret(string[] Dict)
        {
            Output("\n Click anything to generate 10 ideas \n");
            Console.ReadKey();
            Gen(Dict);
        }
        static void Main(string[] args)
        {
            string text;
            string[] Dictionary;

            Output("Please input what word you want to use seperated by ',' character \n");
            text = Console.ReadLine();
            Dictionary = text.Split(',');

            Ret(Dictionary);
        }
    }
}
