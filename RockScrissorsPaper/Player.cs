using System;
using System.Linq;

namespace RockScrissorsPaper
{
    class Player
    {
         static public int[] moves = Array.Empty<int>();

        public int MoveGenerator(int input)
        {
            Random random = new Random();
            int randomIndex = random.Next(input);
            return randomIndex;
        }

        public int[] Get()
        {
            return moves;
        }
        public void Set(int value)
        {
            moves.Append(value);
        }
}
}
