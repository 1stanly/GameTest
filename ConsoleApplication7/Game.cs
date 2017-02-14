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
        GetPlayerCard getPC = new GetPlayerCard();
        GetCasinoCard getCC = new GetCasinoCard();

        public void StartRoundTwoCards()
        {
            ViewModel.playerSum = 0;
            ViewModel.casinoSum = 0;
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                getPC.GetPC();
                getCC.GetCC();

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
            getPC.GetPC();
            getCC.GetCC();

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
    }
}
