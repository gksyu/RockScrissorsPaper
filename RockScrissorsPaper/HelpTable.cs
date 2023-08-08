using System;
using System.Linq;
using ConsoleTables;

namespace RockScrissorsPaper
{
    class HelpTable
    {
        public static void GetTable()
        {
            string[] ColNames1 = { "PC\\User" };
            string[] ColNames = ColNames1.Concat(Rules.Get()).ToArray();

            var table = new ConsoleTable(ColNames);
           
            for (int i = 1; i < ColNames.Length; i++)
            {
                 string[] Row = new String[ColNames.Length];
                 for (int j = 0; j < ColNames.Length; j++)
                 {
                     if (j == 0)
                     {
                         Row[j] = ColNames[i];
                     }
                     else
                     Row[j] = TableResult(i, j, ColNames.Length-1);
                 }
                 table.AddRow(Row);
            }
            Console.WriteLine(table);
        }

        public static string TableResult(int move1, int move2, int moves)
        {
            string result = Rules.Winner(move1, move2, moves);

            if (result == "User")
                return "Win";
            else if (result == "Computer")
                return "Lose";
            else
                return "Draw";
        }
    }
}
