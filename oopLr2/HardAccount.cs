namespace oopLr2
{
    public class HardAccount : Account
    {
        public HardAccount(string userName)
        {
            RatingCoefficient = 2;
            Level = LevelAccount.Hard;
            UserName = userName;
            CurrentRating = 500;
        }
    }
}