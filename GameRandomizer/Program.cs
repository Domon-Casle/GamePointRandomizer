using System;
using System.Collections.Generic;

namespace GameRunPointRandomizer
{
    class Program
    {
        private enum Scoring
        {
            HighestHeat,
            LowestTotalHealth,
            MostEndingCoin,
            MostBoons,
            MostDeathDefinancesLeft,
            MostHeroicDuoLegendaryBoons,
            CharonBattle,
            FishCaught
        }

        static void Main(string[] args)
        {
            bool keepLooping = true;
            var rand = new Random();

            Console.WriteLine("Welcome to the Hades Party Picker");
            ShowHelp();

            while (keepLooping)
            {
                var result = Console.ReadLine();

                switch (result.ToLower())
                {
                    case "p":
                    case "r":
                    case "pick":
                    case "run":
                        List<int> oldPicks = new List<int>();

                        while (oldPicks.Count < 3)
                        {
                            var pick = rand.Next(Enum.GetNames(typeof(Scoring)).Length);

                            if (!oldPicks.Contains(pick))
                            {
                                oldPicks.Add(pick);
                                Console.WriteLine($"Pick: {(Scoring)pick}");
                            }
                        }
                        break;

                    case "q":
                    case "quit":
                        Console.WriteLine("Quitting Program");
                        keepLooping = false;
                        break;

                    case "h":
                    case "help":
                        ShowHelp();
                        break;

                    default:
                        Console.WriteLine("Type help(h) for options");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine("To run type pick(p) or run(r)");
            Console.WriteLine("To Quit type quit(q)");
            Console.WriteLine("Type help(h) for all options");
            Console.WriteLine();
        }
    }
}
