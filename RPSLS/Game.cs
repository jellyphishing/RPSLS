using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player PlayerOne;
        public Player PlayerTwo;

        //Constructor
        public Game()
        {
            
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS, the funnest game in the Galaxy! Here's the lowdown on the rules:\n" +
                "Rock crushes Scissors.\n" +
                "Rock crushes Lizard.\n" +
                "Scissors cuts Paper.\n" +
                "Scissors decapitates Lizard.EEK!\n" +
                "Paper covers Rock.\n" +
                "Paper disproves Spock.\n" +
                "Lizard poisons Spock.\n" +
                "Lizard eats Paper.\n" +
                "Spock smashes Scissors.\n" +
                "Spock vaporizes Rock! YEESSSS!\n" +
                "Game will be best of 3 and the winner will take the title of Best In Universe.\n" +
                "Let the game begin!!!!!!!!\n");
        }

        public int ChooseNumberOfHumanPlayers()

        {
            string numberOfPlayers;
            Console.WriteLine("Choose number of players, 1 or 2.");
            string userInput = Console.ReadLine();
            int covertedUserInput = int.Parse(userInput);
            return covertedUserInput;
            
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("What is your name?");
                string userOneName = Console.ReadLine();
                PlayerOne = new HumanPlayer(userOneName);
                PlayerTwo = new ComputerPlayer("BotBot");
            }
            else
            
            {
                Console.WriteLine("What is your name?")
                ;
                string userTwoName = Console.ReadLine();
                PlayerTwo = new HumanPlayer(userTwoName);

            }
        }

        public void CompareGestures()

        {
            if (PlayerOne.ChosenGesture == PlayerTwo.ChosenGesture)
            {
                Console.WriteLine("Tied! Try again!");
            }

            else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round1");
            }

            else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerTwo.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }
            else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }
            else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }
            else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }
            else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine($"{PlayerOne.Name} wins the round.");
            }

            else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine($"{PlayerTwo.Name} wins the round.");            }

        }

                 public void DisplayGameWinner()
        {
            if(PlayerOne.Score ==2)
            {
                Console.WriteLine($"{PlayerOne.Name} is the winner! Congrats {PlayerOne.Name}");
            }
            else
            {
                Console.WriteLine($"{PlayerTwo.Name} is the winner! Congrats {PlayerTwo.Name}!");
            }

        }

        public void RunGame()
        {
            WelcomeMessage();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            CompareGestures();
            DisplayGameWinner();


           
        }
    }
}
