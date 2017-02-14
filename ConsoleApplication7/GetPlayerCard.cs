using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class GetPlayerCard
    {
        public void GetPC()
        {
            ViewModel.PlayerHandCards.Add(new Card() { Name = Deck.DeckForGame.First().Name, Suit = Deck.DeckForGame.First().Suit, Value = Deck.DeckForGame.First().Value });
            ViewModel.playerSum += ViewModel.PlayerHandCards.Last().Value;
            Deck.DeckForGame.Remove(Deck.DeckForGame.First());
        }
    }
}
