using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    enum Names { Six, Seven, Eight, Nine, Ten, Valet, Dama, Korol, Tuz }
    public class Deck
    {
        int[] arr = new int[] { 6, 7, 8, 9, 10, 2, 3, 4, 11 };

        public List<Card> DeckList = new List<Card>();
        static  public List<Card> DeckForGame = new List<Card>();
        public int randIndexCard;
        Random rand = new Random();
        public int maxValSuits = 3;
        public int minNameNum=0;
        public int maxNameNum=4;
        public int minNameImg = 5;
        public int maxNameImg = 8;
        public int minVal=6;

        public void CreateDeck()
        {
            for (int i = 0; i <=maxValSuits; i++)
            {
                for (int j = minNameNum; j <= maxNameNum; j++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Name = ((Names)j).ToString();
                    card.Value = minVal;
                    minVal++;
                    DeckList.Add(card);
                }
                minVal = 6;
                for (int x= minNameImg; x <= maxNameImg; x++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Name = ((Names)x).ToString();
                    if(card.Name == "Valet")
                    {
                        card.Value = 2;
                    }
                    if (card.Name == "Dama")
                    {
                        card.Value = 3;
                    }
                    if (card.Name == "Korol")
                    {
                        card.Value = 4;
                    }
                    if (card.Name == "Tuz")
                    {
                        card.Value = 11;
                    }
                    DeckList.Add(card);
                }
            }
            foreach(Card n in DeckList)
            {
                Console.WriteLine(n.Name + n.Suit+n.Value);
            }
                //RandomDeck();
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
