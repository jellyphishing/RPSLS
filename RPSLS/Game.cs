﻿using System;
using System.Collections.Generic;
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
            //return 0;  //(this 0 is a place holder) (Console.ReadLine() "Choose number of players, 1 or 2Write Line
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
            else { }
        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {
            if(PlayerOne.Score ==2)
            {
                Console.WriteLine($"{PlayerOne.Name} is the winner!");
            }
            else if(PlayerTwo.Score ==2) 
            {
                Console.WriteLine($"{PlayerTwo.Name} is the winner!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            //ChooseNumberOfHumanPlayers();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            CompareGestures();
            DisplayGameWinner();


           
            //    CreatePlayerObjects(numberOfHumanPlayers);
            //DisplayGameWinner();
            //}
        }
    }
}
