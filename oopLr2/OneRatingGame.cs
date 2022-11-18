namespace oopLr2
{
    public class OneRatingGame:BaseGame
    {
        public OneRatingGame()
        {
            Type = TypeGame.OneRating.ToString();
        }
        public override int Game(Account account1, Account account2, Result result)
        {
            int rating = Random.Next(90, 110);

            if (result == Result.Win)
            {
                account2.CurrentRating -= account2.RatingCoefficient*rating;
            }
            else
            {
                account2.CurrentRating += rating;
            }

            return rating;
        }
    }
}