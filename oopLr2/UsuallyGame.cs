namespace oopLr2
{
    public class UsuallyGame:BaseGame
    {
        public UsuallyGame()
        {
            TipeGames = "Usually";
            Rating = Random.Next(90, 110);
        }

        public override void Game(Account account1, Account account2, string result)
        {
            if (result.Equals("Win"))
            {
                account1.CurrentRating += Rating;
                if (account2.Level.Equals("Usually")  ||  account2.Level.Equals("Easy"))
                {
                    account2.CurrentRating -= Rating;
                }
                else
                {
                    account2.CurrentRating -= 2*Rating;
                }
            }
            else
            {
                account2.CurrentRating += Rating;
                if (account1.Level.Equals("Usually")  ||  account1.Level.Equals("Easy"))
                {
                    account1.CurrentRating -= Rating;
                }
                else
                {
                    account1.CurrentRating -= 2*Rating;
                }
            }
        }
    }
}