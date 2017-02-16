using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Game
    {
        private int _maxValueCards = 21;

        public void StartRoundTwoCards()
        {
            ViewModel.playerSum = 0;
            ViewModel.casinoSum = 0;
            ConsoleIO.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                GetPlayerCard();
                GetCasinoCard();

                ConsoleIO.ShowCards();
            }
            ConsoleIO.ResultCards();
        }
        public void FirstCheck()
        {
            if (ViewModel.playerSum <= _maxValueCards && ViewModel.casinoSum > _maxValueCards)
            {
                ConsoleIO.YouWin();
            }
            if (ViewModel.playerSum > _maxValueCards && ViewModel.casinoSum <= _maxValueCards)
            {
                ConsoleIO.YouLose();
            }
            if (ViewModel.playerSum > _maxValueCards && ViewModel.casinoSum > _maxValueCards)
            {
                ConsoleIO.YouEqual();
            }
            else
            {
                ConsoleIO.NextCard();
            }
        }
        public void NextRound()
        {
            GetPlayerCard();
            GetCasinoCard();

            ConsoleIO.ShowCards();
            ConsoleIO.ResultCards();
        }
        public void FinishCheck()
        {
            if ((ViewModel.playerSum > ViewModel.casinoSum && ViewModel.playerSum <= _maxValueCards) || ((ViewModel.playerSum < ViewModel.casinoSum && ViewModel.playerSum <= _maxValueCards && ViewModel.casinoSum > _maxValueCards)) || (ViewModel.playerSum < ViewModel.casinoSum && ViewModel.playerSum < _maxValueCards && ViewModel.casinoSum > _maxValueCards))
            {
                ConsoleIO.YouWin();
            }
            if ((ViewModel.playerSum < ViewModel.casinoSum && ViewModel.casinoSum <= _maxValueCards) || (ViewModel.playerSum > ViewModel.casinoSum && ViewModel.playerSum > _maxValueCards && ViewModel.casinoSum < _maxValueCards) || (ViewModel.playerSum > ViewModel.casinoSum && ViewModel.playerSum > _maxValueCards && ViewModel.casinoSum <= _maxValueCards))
            {
                ConsoleIO.YouLose();
            }
            if ((ViewModel.playerSum == ViewModel.casinoSum) || (ViewModel.playerSum > _maxValueCards && ViewModel.casinoSum > _maxValueCards))
            {
                ConsoleIO.YouEqual();
            }
        }
        private void GetPlayerCard()
        {
            ViewModel.PlayerHandCards.Add(new Card() { Name = Deck.DeckForGame.First().Name, Suit = Deck.DeckForGame.First().Suit, Value = Deck.DeckForGame.First().Value });
            ViewModel.playerSum += ViewModel.PlayerHandCards.Last().Value;
            Deck.DeckForGame.Remove(Deck.DeckForGame.First());
        }
        private void GetCasinoCard()
        {
            ViewModel.CasinoHandCards.Add(new Card() { Name = Deck.DeckForGame.First().Name, Suit = Deck.DeckForGame.First().Suit, Value = Deck.DeckForGame.First().Value });
            ViewModel.casinoSum += ViewModel.CasinoHandCards.Last().Value;
            Deck.DeckForGame.Remove(Deck.DeckForGame.First());
        }
    }
}
