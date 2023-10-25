using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static GameCardLib.Enums;

namespace GameCardLib
{
    public class Card
    {
        private Suits suit;
        private Values value;

        public Card(Suits suit, Values value) {
            this.suit = suit;
            this.value = value;
        }

        public int getValue()
        {
            int result = 0;

            switch (value)
            {
                case Enums.Values.ace:
                    result = 11;
                    break;

                case Enums.Values.two:
                    result = 2;
                    break;

                case Enums.Values.three:
                    result = 3;
                    break;

                case Enums.Values.four:
                    result = 4;
                    break;

                case Enums.Values.five:
                    result = 5;
                    break;

                case Enums.Values.six:
                    result = 6;
                    break;

                case Enums.Values.seven:
                    result = 7;
                    break;

                case Enums.Values.eight:
                    result = 8;
                    break;

                case Enums.Values.nine:
                    result = 9;
                    break;

                case Enums.Values.ten:
                case Enums.Values.jack:
                case Enums.Values.queen:
                case Enums.Values.king:
                    result = 10;
                    break;

            }

            return result;
        }

        public override string ToString()
        {
            return(value.ToString() + " of " + suit.ToString());
        }
    }
}
