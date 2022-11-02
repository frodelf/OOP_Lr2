using System;

namespace oopLr2
{
    public abstract class BaseGame
    {
        public static Random Random = new Random();
        public string TipeGames;
        public int Rating;

        public abstract void Game(Account account1, Account account2, string result);
    }
}