using System;


namespace Cse210_HandLgame
{
    ///Card class gets the input of l/h and add the points 

    public class Card
    {
        public int _valueOld;
        public int _value;
        public int _addScore;
        public Card()
        {
           //string playerChoice = 'l';
           _valueOld = 0;
           _addScore = 0;
           
        }
        ///<summary> this is for cards </summary> 
        public void PlayerInput(int score)
        {
            
            //asks for the l/h
            Console.Write("Higher or Lower? [h/l] ");
            string playerChoice = Console.ReadLine();
           
            //to compute hte scores 
            if (playerChoice == "l" )
            {
                //They got the guess right 
                if (_value < _valueOld )
                {
                    _addScore = 100;
                }
                else 
                {
                    _addScore = -75;
                }
            }
            else
            {
                //They guessed right with h 
                if (_value > _valueOld )
                {
                    _addScore = 100;
                }
                else 
                {
                    _addScore = -75;
                }

            }
            Console.WriteLine($"Your score is: {score + _addScore}"); 
                    
            
        }

    }


}
