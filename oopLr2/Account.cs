using System;
using System.Collections.Generic;

namespace oopLr2
{
    public abstract class Account
    {
        public string Level;
        public string UserName;
        public int CurrentRating;
        public static int GamesCount;
        public static List<GameList> GameLists = new List<GameList>();

        public abstract void WinGame(Account opponent, string typeGames);
        public abstract void LoseGame(Account opponent, string typeGames);

        public static void HistoryGames()
        {
            foreach (var game in GameLists)
            {
                Console.WriteLine("ID: "+game.GamesCount);
                Console.WriteLine("Type Game: "+game.Tipe);
                Console.WriteLine("Player 1: "+game.Player1.UserName);
                Console.WriteLine("Player 2: "+game.Player2.UserName);
                Console.WriteLine(game.Player1.UserName +" "+ game.Result);
                Console.WriteLine("Rating: "+game.Rating);
                Console.WriteLine();
            }
        }
    }
}