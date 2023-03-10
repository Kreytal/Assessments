using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }

        public int Suit { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Value} - {Suit}");
        }
    }
        
}
