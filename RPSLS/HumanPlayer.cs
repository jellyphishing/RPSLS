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


        public HumanPlayer(string name)
            :base(name)
        {
            
        }
          //Methods (CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine( "Press 0 for rock, press 1 for paper, press 2 for scissors, press 3 for lizard, press 4 for Spock.");
            int chosenNumber = int.Parse(Console.ReadLine());
            ChosenGesture = gestures[chosenNumber];
           
        }



        
    }
}