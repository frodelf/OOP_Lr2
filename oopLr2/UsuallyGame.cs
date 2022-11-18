namespace oopLr2
{
    public class UsuallyGame:BaseGame
    {
        public UsuallyGame()
        {
            Type = TypeGame.Usually.ToString();
        }
        public override int Game(Account account1, Account account2, Result result)
        {
            int rating = Random.Next(90, 110);
            if (result == Result.Win)
            {
                account1.CurrentRating += rating;
                account2.CurrentRating -= account2.RatingCoefficient*rating;
            }
            else
            {
                account2.CurrentRating += rating;
                account1.CurrentRating -= account2.RatingCoefficient*rating;
            }

            return rating;
        }
    }
}