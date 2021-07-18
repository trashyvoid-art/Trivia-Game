using System;
using static System.Console;

//the below allows the use of lists!
using System.Collections.Generic;

namespace TriviaGameGroup
{
    public class Game
    {
        //This is how to use a list!
        // List<Class> Identifier = New List<Class>() and so on and so fourth
        List<TriviaItem> FunFacts = new List<TriviaItem>()
        {
            //Each quote corresponds to the constructor in the TriviaItem class!
            new TriviaItem("What fact about dolphins is false?","B",
                "A) Dolphins have their own language", "B) Sharks and Dolphins are besties",
                "C) Dolphins willingly intoxicate themselves"),

            new TriviaItem("What fact about penguins is true?", "C",
                "A) Penguins are Santa's helpers",
                "B) Pingu is a nature documentary",
                "C) Penguins do not live at the north pole"
                ),

            new TriviaItem("What fact about Nichelle Nichols is false?","A",
                "A) She is very good friends with WIlliam Shatner",
                "B) She helped NASA recruit PoC into the space program",
                "C) Martin Luther King himself told her not to quit Star Trek"),

            new TriviaItem("What enshrouds the Solar System?", "B",
                "A) Absolutely nothing",
                "B) The Oort Cloud",
                "C) Our future alien overlords")
        };

        List<TriviaItem> HardFacts = new List<TriviaItem>()
        {
            new TriviaItem("Was Nixon a crook?","Yes",
                "Yes",
                "No",
                "Maybe"),

            new TriviaItem("Why is Saturn shaped like that?","B",
                "A) She's built different, your honor",
                "B) It's intense gravity and speedy rotation",
                "C) Radioactive effects from the sun"),

            new TriviaItem("What is the secret to life?", "42",
                "A)Personal joy",
                "B) Spiritual faith",
                "C) The everlasting existence of the Void")

        };

        Player player;
        string Input;
        string Mode;
        int qNum=0;

        public Game()
        {
            player = new Player();
            WriteLine("Welcome to trivia funfacts! What's your name?");
            player.Name = ReadLine();
            WriteLine($"Nice to meet you, {player.Name}!");
            WriteLine("Would you like to play Easy or Hard?");
            Mode = ReadLine();
            if (Mode.ToLower() == "easy" )
            {
                WriteLine("Now beginning easy mode! Press any key to continue");
                ReadKey();
                EasyMode();
            }
            else
            {
                WriteLine("Now beginning hard mode! Press any key to continue");
                ReadKey();
                HardMode();
            }
            WriteLine($"Thanks for playing, {player.Name}!\nTOTAL POINTS: {player.points}");
            WriteLine("Would you like to try hard mode?");
            Mode = ReadLine();
            if(Mode.ToLower() == "yes")
            {
                WriteLine("Now beginning hard mode! Press any key to continue");
                ReadKey();
                HardMode();
                WriteLine($"Thanks for playing, {player.Name}!\nTOTAL POINTS: {player.points}");
            }
            else
            {
                WriteLine("Understood! Thanks for playing!");
            }
            ReadKey();
        }

        public void EasyMode()
        {
            foreach(TriviaItem Item in FunFacts)
            {
                qNum++;

                ForegroundColor = ConsoleColor.Green;
                WriteLine($"{qNum}.{Item.question}");
                WriteLine(Item.Choice1);
                WriteLine(Item.Choice2);
                WriteLine(Item.Choice3);
                ResetColor();
                Input = ReadLine();

                //the method needs the referenced constructor to function
                CheckAnswer(Input, Item.answer);
                ReadKey();

            }
        }

        public void HardMode()
        {
            foreach(TriviaItem Item2 in HardFacts)
            {
                qNum++;

                ForegroundColor = ConsoleColor.Red;
                WriteLine($"{qNum}.{Item2.question}");
                WriteLine(Item2.Choice1);
                WriteLine(Item2.Choice2);
                WriteLine(Item2.Choice3);
                ResetColor();
                Input = ReadLine();

                //the method needs the referenced constructor to function
                CheckAnswer(Input, Item2.answer);
                ReadKey();
            }
        }

        //a method to check if the answer was correct or not
        public void CheckAnswer(string Input, string answer)
        {

            if (Input.ToLower() == answer.ToLower() )
            {
                player.AddPoints();
                WriteLine($"Correct! You now have {player.points} token in points.");

            }
            else
            {
                player.SubPoints();
                WriteLine($"Wrong! The answer was {answer}");
                WriteLine($"Your points are now at {player.points}");
            }

        }
    }
}
