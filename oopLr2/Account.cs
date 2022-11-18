using System;
using System.Collections.Generic;

namespace oopLr2
{
    public abstract class Account
    {
        protected LevelAccount Level;
        protected int WinGames;
        public int RatingCoefficient;
        public int CurrentRating;
        protected string UserName;
        private static int _gamesCount;
        private static readonly List<GameList> GameLists = new List<GameList>();

        public void WinGame(Account opponent, BaseGame typeGames)
        {
            int rating = typeGames.Game(this, opponent, BaseGame.Result.Win);
            if (Level == LevelAccount.Easy)
            {
                if (++WinGames == 3)
                {
                    CurrentRating += 100;
                    WinGames = 0;
                }
            }
            
            GameLists.Add(new GameList(++_gamesCount,typeGames.Type,this,opponent,"Win", rating));
        }

        public void LoseGame(Account opponent, BaseGame typeGames)
        {
            int rating = typeGames.Game(this, opponent, BaseGame.Result.Lose);
            if (Level == LevelAccount.Easy)
            {
                WinGames = 0;
            }
            
            GameLists.Add(new GameList(++_gamesCount,typeGames.Type,this,opponent,"Lose", rating));
        }

        public static void HistoryGames()
        {
            foreach (var game in GameLists)
            {
                Console.WriteLine("ID: "+game.GamesCount);
                Console.WriteLine("Type Game: "+game.Type);
                Console.WriteLine("Player 1: "+game.Player1.UserName);
                Console.WriteLine("Player 2: "+game.Player2.UserName);
                Console.WriteLine(game.Player1.UserName +" "+ game.Result);
                Console.WriteLine("Rating: "+game.Rating);
                Console.WriteLine();
            }
        }

        protected enum LevelAccount
        {
            Easy,
            Usually,
            Hard,
        }
    }
}