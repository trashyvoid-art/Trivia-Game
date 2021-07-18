using System;
using static System.Console;
namespace TriviaGameGroup
{
    public class TriviaItem
    {
        public string question;
        public string answer;
        public string Choice1;
        public string Choice2;
        public string Choice3;

        //The class constructor, to make instatiating easier!
        public TriviaItem(string _question, string _ans, string c1, string c2, string c3)
        {
            question = _question;
            answer = _ans;
            Choice1 = c1;
            Choice2 = c2;
            Choice3 = c3;

        }
    }
}
