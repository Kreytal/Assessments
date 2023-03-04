using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Pack
    {
        List<Card> packOfCards = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here
            for (int value = 1; value < 14; value++)
			{
                for (int suit = 0; suit < length; suit++)
			    {
                    string card = $"value {value} - suit {suit}"
                    packOfCards.Add(new Card(card))
			    }
			}
            Console.WriteLine(packOfCards);
        }

        //public static bool shuffleCardPack(int typeOfShuffle)
        //{ 
        //}
        //public static Card deal()
        //{
            //Deals one card

        //}
        //public static List<Card> dealCard(int amount)
        //{
            //Deals the number of cards specified by 'amount'
        //}
    }
}
