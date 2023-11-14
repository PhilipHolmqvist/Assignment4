using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJGameEL
{
    public class PlayerEvent : EventArgs
    {

        private Boolean wantsHit; // If the player wants to hit or stand. 
        private Boolean isBust;

        public PlayerEvent(Boolean wantsHit, Boolean isBust) 
        {
            this.wantsHit = wantsHit;
            this.isBust = IsBust;
        }

        //Getters and setters.

        public Boolean WantsHit 
        {
            get { return wantsHit; }
            set { wantsHit = value; }
        }

        public Boolean IsBust
        {
            get { return isBust; }
            set { isBust = value; }
        }
    }
}
