namespace oopLr2
{
    public class CreateAccount
    {
        private static int _indexP;
        public BonusAccount BonusAccount()
        {
            return new BonusAccount("player" + (++_indexP));
        }

        public GameAccount GameAccount()
        {
            return new GameAccount("player" + (++_indexP));
        }

        public HardAccount HardAccount()
        {
            return new HardAccount("player" + (++_indexP));
        }
    }
}