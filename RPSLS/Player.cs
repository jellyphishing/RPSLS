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
            this.name = name;
            gestures = new List<string> {"rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }
}
