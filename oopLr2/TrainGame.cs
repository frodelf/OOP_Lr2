namespace oopLr2
{
    public class TrainGame:BaseGame
    {
        public TrainGame ()
        {
            TipeGames = "Train";
            Rating = Random.Next(90, 110);
        }

        public override void Game(Account account1, Account account2, string result)
        {
        }
    }
}