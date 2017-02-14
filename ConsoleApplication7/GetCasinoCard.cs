using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class GetCasinoCard
    {
        public void GetCC()
        {
            ViewModel.CasinoHandCards.Add(new Card() { Name = Deck.DeckForGame.First().Name, Suit = Deck.DeckForGame.First().Suit, Value = Deck.DeckForGame.First().Value });
            ViewModel.casinoSum += ViewModel.CasinoHandCards.Last().Value;
            Deck.DeckForGame.Remove(Deck.DeckForGame.First());
        }
    }
}
