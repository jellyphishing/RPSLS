using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {

        public ComputerPlayer(string name)
           : base(name)
        {
            this.Name = name;
            Random rand;


            
        }
        
                                           
              
    
        public override void ChooseGesture()
        {
            Random rand = new Random();
            int chosenNumber = rand.Next(0, 4);
            ChosenGesture = Gestures[chosenNumber];
            
        }
    }
}

