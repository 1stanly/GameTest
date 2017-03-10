using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    enum Names { Six, Seven, Eight, Nine, Ten, Valet, Dama, Korol, Tuz }
    enum Value { Six, Seven, Eight, Nine, Ten, Two, Three, Four, Eleven }
    public class Deck
    {
        public List<Card> DeckList = new List<Card>();
        static  public List<Card> DeckForGame = new List<Card>();
        public int randIndexCard;
        Random rand = new Random();
        public int maxValSuits = 3;
        public int minNameNum=0;
        public int maxNameNum=4;
        public int minNameImg = 0;
        public int maxNameImg = 3;

        public void CreateDeck()
        {
            for (int i = 0; i <=maxValSuits; i++)
            {
                for (int j = minNameNum; j <= maxNameNum; j++)
                {
                    Card c = new Card();
                    c.Suit = (Suit)i;
                    c.Name = (Names)j;
                    c.Value = (Value)j;
                    DeckList.Add(c);
                }
                for(int x= minNameImg; x <= maxNameImg; x++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Name = (Names)x;
                    card.Value = (Value)x;
                    DeckList.Add(card);
                }
            }
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
