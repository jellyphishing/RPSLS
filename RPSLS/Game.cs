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
            int covertedUserInput = 0;
            while (covertedUserInput < 1 || covertedUserInput > 3)
            {
                Console.WriteLine("Choose number of players, 1 or 2.");
                string userInput = Console.ReadLine();
                covertedUserInput = int.Parse(userInput);
            }
           
            
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
            else if (numberOfHumanPlayers == 2) 
            
            {
                Console.WriteLine("Player 1, what is your name?");
                string userOneName = Console.ReadLine();
                PlayerOne = new HumanPlayer(userOneName);


                Console.WriteLine("Player 2, what is your name?");                               
                string userTwoName = Console.ReadLine();
                PlayerTwo = new HumanPlayer(userTwoName);

            }
            else
            {
                Console.WriteLine("You entered something incorrect...Now you get 2 computer players");
                PlayerOne = new ComputerPlayer("BotBot");
                PlayerTwo = new ComputerPlayer("Botbot2");
            }
        }

        public void CompareGestures()

        {


            while (PlayerOne.Score < 3 && PlayerTwo.Score < 3)
            {
                PlayerOne.ChooseGesture();
                PlayerTwo.ChooseGesture();

                if (PlayerOne.ChosenGesture == PlayerTwo.ChosenGesture)
                {
                    Console.WriteLine("Tied! Try again!");
                }

                else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Paper")
                {
                    Console.WriteLine($"Paper covers Rock! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }
                else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Scissors")
                {
                    Console.WriteLine($"Rock smashes Scissors! {PlayerOne.Name} wins the round1");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Lizard")
                {
                    Console.WriteLine($"Rock crushes Lizard! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Rock" && PlayerTwo.ChosenGesture == "Spock")
                {
                    Console.WriteLine($"Spock vaporizes Rock! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerTwo.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Rock")
                {
                    Console.WriteLine($"Paper covers Rock! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Scissors")
                {
                    Console.WriteLine($"Scissors cuts Paper! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Lizard")
                {
                    Console.WriteLine($"Lizard eats Paper! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Paper" && PlayerTwo.ChosenGesture == "Spock")
                {
                    Console.WriteLine($"Paper disproves Spock! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Rock")
                {
                    Console.WriteLine($"Rock crushes Scissors! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Paper")
                {
                    Console.WriteLine($"Scissors cuts Paper! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Lizard")
                {
                    Console.WriteLine($"Scissors decapitates Lizard! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Scissors" && PlayerTwo.ChosenGesture == "Spock")
                {
                    Console.WriteLine($"Spock smashes Scissors! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Rock")
                {
                    Console.WriteLine($"Rock crushes Lizard! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Paper")
                {
                    Console.WriteLine($"Lizard eats Paper! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }
                else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Scissors")
                {
                    Console.WriteLine($"Scissors decapitates Lizard! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }
                else if (PlayerOne.ChosenGesture == "Lizard" && PlayerTwo.ChosenGesture == "Spock")
                {
                    Console.WriteLine($"Lizard poisons Spock! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }
                else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Rock")
                {
                    Console.WriteLine($"Spock vaporizes Rock! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }
                else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Paper")
                {
                    Console.WriteLine($"Paper disproves Spock! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Scissors")
                {
                    Console.WriteLine($"Spock smashes Scissors! {PlayerOne.Name} wins the round.");
                    PlayerOne.Score++;
                }

                else if (PlayerOne.ChosenGesture == "Spock" && PlayerTwo.ChosenGesture == "Lizard")
                {
                    Console.WriteLine($"Lizard poisons Spock! {PlayerTwo.Name} wins the round.");
                    PlayerTwo.Score++;
                }
            }
        

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
