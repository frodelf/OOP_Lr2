namespace oopLr2
{
    public class GameAccount : Account
    {
        public GameAccount(string userName)
        {
            RatingCoefficient = 1;
            Level = LevelAccount.Usually;
            UserName = userName;
            CurrentRating = 1000;
        }
    }
}