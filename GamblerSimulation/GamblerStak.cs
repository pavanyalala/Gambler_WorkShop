using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerSimulation
{
    class GamblerStak
    {
        public void Game()
        {
            int START = 100;
            const int BET = 1;

            Random random = new Random();
            int check = random.Next(1, 3);
            if(check == 1)
            {
                Console.WriteLine("Game Won");
                START = START + BET;
            }
                
            else
            {
                Console.WriteLine("Game lost");
                START = START - BET;
            }
            Console.WriteLine("Final Amount : " + START);
        }
    }
}
