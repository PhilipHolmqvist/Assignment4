using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class PlayerEvent : EventArgs
    {

        private Boolean wantsHit; // If the player wants to hit or stand. 

        public PlayerEvent(Boolean wantsHit) 
        {
            this.wantsHit = wantsHit;
        }

        //Getters and setters.

        public Boolean WantsHit 
        {
            get { return wantsHit; }
            set { wantsHit = value; }
        }
    }
}
