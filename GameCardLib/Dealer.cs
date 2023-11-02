using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;


namespace GameCardLib
{

    //This class is the subscriber. 
    public class Dealer : Player
    {

       
       
        public Dealer(string playername, int playerId) : base(playername, playerId)
        {
            this.playerName = playername;
            this.playerId = playerId;
        }

    }
}
