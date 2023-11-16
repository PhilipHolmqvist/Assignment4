
using System.ComponentModel.DataAnnotations;
using static BJGameEL.Enums;

namespace BJGameEL
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public Suits suit;
        public Values value;
        
        public Card() { }

        public Card(Suits suit, Values value) {
            this.suit = suit;
            this.value = value;
        }

        public Suits getSuits()
        {
            return suit;
        }

        public Values getValue()
        {
            return value;
        }

        public int getCardIntValue()
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
