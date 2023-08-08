using System;
using System.Linq;

namespace RockScrissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] moves = args;
            Rules.Set(moves);

            if (moves.Length < 3 || moves.Length % 2 == 0)
            {
                Console.WriteLine("Error: Please provide an odd number of unique moves (>= 3).");
                return;
            }
            else if (moves.Distinct().Count() != moves.Length)
            {
                Console.WriteLine("The input moves must be unique values");
                return;
            }

            Player user = new Player();
            Player pc = new Player();
            int pcMove, userMove, MoveCount = 0;

            while (true)
            {
                MoveCount++;
                string key = Key.RandKeyGenerator();
                pcMove = pc.MoveGenerator(moves.Length);     pc.Set(pcMove);
                string hmac = key + pcMove;
                Console.WriteLine("HMAC: " + HMAC.CalculateHMAC(hmac));

                MovesMenu(moves);
                userMove = UserChoice(moves.Length);     user.Set(userMove-1);
                if (userMove == 0) break;
                Console.WriteLine("User move: " + moves[userMove-1]);
                Console.WriteLine("PC move: " + moves[pcMove]);
                Console.WriteLine("You " + HelpTable.TableResult(userMove-1, pcMove, MoveCount));
                Console.WriteLine("HMAC key: " + key);
                Console.WriteLine("--------------------------------------------");
            }
        }

        static void MovesMenu(string[] moves)
        {
            for (int i = 1; i <= moves.Length+1; i++)
            {
                if (i <= moves.Length)
                    Console.WriteLine(i + " - " + moves[i - 1]);
                else
                {
                    Console.WriteLine("0 - exit");
                    Console.WriteLine("? - help");
                }
            }
        }
        static int UserChoice(int NumMoves)
        {
            int intMoveChoice;
            string strMoveChoice; 
            while (true)
            {
                Console.Write("Enter your move: ");
                strMoveChoice = Console.ReadLine();
                if (int.TryParse(strMoveChoice, out intMoveChoice) && intMoveChoice >= 0 && intMoveChoice <= NumMoves)
                    return intMoveChoice;
                else if (strMoveChoice == "?")
                { 
                        HelpTable.GetTable();
                }
                else
                    Console.WriteLine("Invalid data. Please try again.");
            }
        }
    }
}
