using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class StartGame
    {
        Game game = new Game();
        Deck deck = new Deck();

        public void HelloPeople()
        {
            ConsoleIO.Hello();
            if (ConsoleIO. yes_or_no == "y")
            {
                StartNewGame();
            }
            if (ConsoleIO. yes_or_no == "n")
            {
                return ;
            }
        }
        public void StartNewGame()
        {
            deck.CrateDeck();
            game.StartRoundTwoCards();
            game.FirstCheck();
        }
        public void StartNextRound()
        {
            game.NextRound();
            game.FirstCheck();
        }

    }
}
