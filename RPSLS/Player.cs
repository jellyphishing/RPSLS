using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string Name;
        public List<string> Gestures;
        public string ChosenGesture;
        public int Score;

        //Constructor
        public Player(string name)
        {
            this.Name = name;
            Gestures = new List<string> {"Rock", "Paper", "Scissors", "Lizard", "Spock" };
            ChosenGesture = "";
            Score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }
}
