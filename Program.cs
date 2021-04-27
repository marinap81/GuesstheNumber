using System;
using System.Collections.Generic;

namespace GuesstheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int magicnumb = 5;
            int userGuess = 0; /*user input*/

            int maxGuesses = 6;
            int numGuesses = 0;
            int guessesleft = 0;
            int isCorrect = 0; /*false-failed*/

            List<int> numList = new List<int>();
                    

            Console.WriteLine("Hey there! Lets play a little guessing game");
            
                
                 
               while(numGuesses++ < maxGuesses && userGuess != magicnumb) /*is it true or false*/
                {
                        Console.WriteLine("Guess number between 0 and 25");
                
                        string usernum = Console.ReadLine();
                        userGuess = int.Parse(usernum);

                        if (userGuess == magicnumb)
                        {
                         isCorrect =1; /*true branch shorthand*/
                            break;
                        }

                        else if (userGuess < magicnumb)
                        {                        
                            Console.WriteLine("Nope, it's more than that");                
                        }
                        else
                        {
                             Console.WriteLine("Nope, it's less than that");
                        }

                        guessesleft = maxGuesses - numGuesses;
                        Console.WriteLine("Wrong, you have" + guessesleft + "guesses left");
                
                        numList.Add(userGuess);
                }
                    

                 if (isCorrect==1)
                 {
                     Console.WriteLine("Damn, you win!");
                     Console.WriteLine("The number was indeed " + magicnumb);
                     Console.WriteLine("You guessed in " + numGuesses);
                 }   
                 else
                 {
                     Console.WriteLine("AAHHAHA, YOU LOSE");
                     Console.WriteLine("The number was " + magicnumb + "YOU FOOL");

                 }
                         
                Console.WriteLine("Your Guess Log");                    ;

                var result = String.Join(", ", numList.ToArray());
                Console.WriteLine("[" + result + "]");

                    
        }
    }
}
