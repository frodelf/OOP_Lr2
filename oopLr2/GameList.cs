namespace oopLr2
{
    public class GameList
    {
        public int GamesCount;
        public string Type; 
        public Account Player1;
        public Account Player2;
        public string Result;
        public int Rating;
        public GameList(int gamesCount, string type, Account player1, Account player2, string result, int rating)
        {
            GamesCount = gamesCount;
            Type = type;
            Player1 = player1;
            Player2 = player2;
            Result = result;
            Rating = rating;
        }
    }
}