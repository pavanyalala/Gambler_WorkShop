using System;

namespace GamblerSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Simulation program");
            GamblerStak gamblerStak = new GamblerStak();
            gamblerStak.Game();
        }
    }
}
