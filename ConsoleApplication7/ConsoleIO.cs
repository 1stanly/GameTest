using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    static public class ConsoleIO
    {
        static public string yes_or_no;
        static Game game = new Game();
        static StartGame startGame = new StartGame();

        static public void Hello()
        {
            Console.WriteLine("\t\t\tHello !!!");
            Console.WriteLine("\t\tDo you want play 'Black Jack ?'");
            yes_or_no = Console.ReadLine();
        }
        static public void ShowCards()
        {
            Console.Write(ViewModel.PlayerHandCards.Last().Name + " " + "'" + ViewModel.PlayerHandCards.Last().Suit + "'" + " " + "=" + " " + ViewModel.PlayerHandCards.Last().Value);
            Console.WriteLine("\t\t" + ViewModel.CasinoHandCards.Last().Name + " " + "'" + ViewModel.CasinoHandCards.Last().Suit + "'" + " " + "=" + " " + ViewModel.CasinoHandCards.Last().Value);
        }
        static public void ResultCards()
        {
            Console.WriteLine();
            Console.Write("Result : \t" + ViewModel.playerSum);
            Console.WriteLine("\t\t" + ViewModel.casinoSum);
            Console.WriteLine();
        }
        static public void NextCard()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tDo you want GET next CARD ?");
            yes_or_no = Console.ReadLine();
            if (yes_or_no == "y")
            {
                startGame.StartNextRound();
            }
            if (yes_or_no == "n")
            {
                game.FinishCheck();
            }
        }
        static public void YouWin()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tYOU WIN !");
            ViewModel.playerWins++;
            Console.WriteLine("\tWINS : "+ViewModel.playerWins+"\t\t"+ViewModel.casinoWins);

            NextGame();
        }
        static public void YouLose()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tYOU LOSE !");
            ViewModel.casinoWins++;
            Console.WriteLine("\tWINS : " + ViewModel.playerWins + "\t\t" + ViewModel.casinoWins);

            NextGame();
        }
        static public void YouEqual()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tYOU EQUAL !");
            Console.WriteLine("\tWINS : " + ViewModel.playerWins + "\t\t" + ViewModel.casinoWins);

            NextGame();
        }
        static public void NextGame()
        {
            Console.WriteLine("DO YOU WANT PLAY AGAIN ???");
            yes_or_no = Console.ReadLine();
            if (yes_or_no == "y")
            {
                startGame.StartNewGame();
            }
            if (yes_or_no == "n")
            {
                Console.WriteLine("\tWINS : " + ViewModel.playerWins + "\t\t" + ViewModel.casinoWins);
                Console.WriteLine("\t\tGOOD  BY !");
            }
        }
    }
}
