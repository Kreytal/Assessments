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
                for (int suit = 1; suit < 5; suit++)
			    {
                    packOfCards.Add(new Card(value, suit));
			    }
			}
            //foreach (Card card in packOfCards)
            //{
            //    card.Show();
            //}
        }

        //public static bool shuffleCardPack(int typeOfShuffle)
        //{

        //}
        //public static Card deal()
        //{
        //    //Deals one card

        //}
        //public static List<Card> dealCard(int amount)
        //{
        //    //Deals the number of cards specified by 'amount'
        //}
    }
}
