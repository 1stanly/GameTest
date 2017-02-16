using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame startGame = new StartGame();
            startGame.HelloPeople();
            ConsoleIO.ReadLine();
        }

    }
}
