using System;

namespace oopLr2
{
    public class GameAccount : Account
    {
        public GameAccount(string userName)
        {
            Level = "Usually";
            UserName = userName;
            CurrentRating = 1000;
        }

        public override void WinGame(Account opponent, string typeGames)
        {
            BaseGame game;
            if (typeGames.Equals("Usually"))
            {
                game = new UsuallyGame();
            }
            else if (typeGames.Equals("Train"))
            {
                game  = new TrainGame();
            }
            else if(typeGames.Equals("OneRating"))
            {
                game = new OneRatingGame();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(typeGames), "type game can be: Usually, Train or OneRating");
            }
            game.Game(this, opponent, "Win");
            
            if (CurrentRating < 0  ||  opponent.CurrentRating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CurrentRating), "current rating can't be less than 0");
            }
            
            if (game.TipeGames.Equals("Train"))
            {
                GameLists.Add(new GameList(++GamesCount, typeGames, this, opponent, "winner", 0));
            }
            else
            {
                GameLists.Add(new GameList(++GamesCount, typeGames, this, opponent, "winner", game.Rating));
            }
        }

        public override void LoseGame(Account opponent, string typeGames)
        {
            BaseGame game;
            if (typeGames.Equals("Usually"))
            {
                game = new UsuallyGame();
            }
            else if (typeGames.Equals("Train"))
            {
                game  = new TrainGame();
            }
            else if(typeGames.Equals("OneRating"))
            {
                game = new OneRatingGame();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(typeGames), "type game can be: Usually, Train or OneRating");
            }
            game.Game(this, opponent, "Lose");
            if (CurrentRating < 0  ||  opponent.CurrentRating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CurrentRating), "current rating can't be less than 0");
            }
            if (game.TipeGames.Equals("Train"))
            {
                GameLists.Add(new GameList(++GamesCount, typeGames, this, opponent, "loser", 0));
            }
            else
            {
                GameLists.Add(new GameList(++GamesCount, typeGames, this, opponent, "loser", game.Rating));
            }
        }
    }
}