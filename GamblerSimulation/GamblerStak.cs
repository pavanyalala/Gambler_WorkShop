using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerSimulation
{
    class GamblerStak
    {
        public void Game()
        {
            const int START = 100;
            const int BET = 1;
            int game = 0;
            for (int i = BET;i<=START;i++)
            {
                game++;
                Console.WriteLine("Number of Games : " + game);
            }
        }
        
    }
}
