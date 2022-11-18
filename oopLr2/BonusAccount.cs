namespace oopLr2
{
    public class BonusAccount : Account
    {
        public BonusAccount(string userName)
        {
            RatingCoefficient = 1;
            Level = LevelAccount.Easy;
            UserName = userName;
            CurrentRating = 1000;
            WinGames = 0;
        }
    }
}