using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Deck
    {
        public List<Card> DeckList = new List<Card>();
        static  public List<Card> DeckForGame = new List<Card>();
        public int randIndexCard;
        Random rand = new Random();
        
        public void CrateDeck()
        {
            string[] ArrNames = new string[] { "6", "7", "8", "9", "10", "Valet", "Dama", "Korol", "TUZ" };
            int[] ArrValues = new int[] { 6, 7, 8, 9, 10, 2, 3, 4, 11 };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Name = ArrNames[i];
                    card.Value = ArrValues[i];
                    card.Suit = (Suit)j;
                    DeckList.Add(card);
                }
            }
            Console.WriteLine();
            RandomDeck();
        }
        public void RandomDeck()
        {
           if(DeckList.Count != 0)
            {
                randIndexCard = rand.Next(DeckList.Count);
                Card cardRand = new Card();
                cardRand.Name = DeckList[randIndexCard].Name;
                cardRand.Value = DeckList[randIndexCard].Value;
                cardRand.Suit = DeckList[randIndexCard].Suit;

                Deck.DeckForGame.Add(cardRand);
                DeckList.RemoveAt(randIndexCard);
              
                RandomDeck();
            }
            else
            {
                return;
            }
        }
    }
}
