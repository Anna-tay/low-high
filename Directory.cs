using System;


namespace Cse210_HandLgame
{
    public class Director
    {
        public int _value1;
        public string _playAgain = "y";
        
        //starts game 
        public Director()
        {
            Random randomGenerator = new Random();
            _value1 = randomGenerator.Next(1,14);
            
        }
        public void StartGame()
        {
            //starts game up and running
            
            int score = 300;
            while(_playAgain == "y")
            {
                //prints all values and plays game 
                PlayGame(score);

                //keeps game going 
                Console.Write("Do you want to play? [y/n] ");
                _playAgain = Console.ReadLine();
                Console.WriteLine();

            }
            Console.WriteLine("Thank you for playing");

        }
/// Prints all the things and asks for user input
        public void PlayGame(int score)
        {
            //also gets the next card 
            Random randomGenerator = new Random();
            int value = randomGenerator.Next(1,14);

            Console.WriteLine($"The card is: {_value1}");
            int newScore = 0;
            //calls the card class 
            Card cards = new Card();
            cards._value = value;
            cards._valueOld = _value1;
            cards._addScore = newScore;
            //cards._addScore = _addScore;
            cards.PlayerInput(score);

            //prints score and the next card value. 
            
            score += newScore;
            Console.WriteLine($"Next card was: {value}");
            _value1 = value;

            if (score == 0)
            {
                _playAgain = "n";
            }

        }        
    }
}
