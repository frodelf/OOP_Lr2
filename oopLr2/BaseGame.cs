using System;

namespace oopLr2
{
    public abstract class BaseGame
    {
        public string Type;
        protected static Random Random = new Random();

        public abstract int Game(Account account1, Account account2, Result result);

        public enum Result
        {
            Win,
            Lose,
        }

        protected enum TypeGame
        {
            Usually,
            OneRating,
            Train,
        }
    }
}