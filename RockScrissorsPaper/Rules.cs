namespace RockScrissorsPaper
{
    class Rules
    {
        static string[] WinArgs;

        public static string[] Get()
        {
            return WinArgs;
        }
        public static void Set(string[] value)
        {
            WinArgs = value;
        }

        public static string Winner(int userMove, int computerMove, int MovesLength)
        {
            int halfLength = MovesLength / 2;

            if (userMove == computerMove)
            { return "Draw"; }
            else if ((computerMove - userMove + MovesLength) % MovesLength > halfLength)
            { return "Computer"; }
            else
            { return "User"; }
        }
    }
}
