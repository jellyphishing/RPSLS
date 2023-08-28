using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    //Member variables (HAS A)
    {
 
     //Constructor


        public HumanPlayer(string name) //finished
            :base(name)
        {
            
        }
          //Methods (CAN DO)
        public override void ChooseGesture() //finished
        {
            Console.WriteLine( "Press 0 for Rock, press 1 for Paper, press 2 for Scissors, press 3 for Lizard, press 4 for Spock.");
            int chosenNumber = int.Parse(Console.ReadLine());
            ChosenGesture = Gestures[chosenNumber];
           
        }



        
    }
}