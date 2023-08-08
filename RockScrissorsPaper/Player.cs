using System;
using System.Linq;
using System.Collections.Generic;

namespace RockScrissorsPaper
{
    class Player
    {
        List<int> moves = new List<int>();

        public int MoveGenerator(int input)
        {
            Random random = new Random();
            int randomIndex = random.Next(input);
            return randomIndex;
        }

        public List<int> Get()
        {
            return moves;
        }
        public void Set(int value)
        {
            moves.Add(value);
        }
}
}
