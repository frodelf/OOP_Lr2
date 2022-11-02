namespace oopLr2
{
    public class OneRatingGame:BaseGame
    {
        public OneRatingGame()
        {
            TipeGames = "OneRating";
            Rating = Random.Next(90, 110);
        }
        public override void Game(Account account1, Account account2, string result)
        {
            
            if (result.Equals("Win"))
            {
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
            }
        }
    }
}