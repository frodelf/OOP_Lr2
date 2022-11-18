using System;

namespace oopLr2
{
    public static class Runner
    {
        static void Main()
        {
            UsuallyGame usuallyGame = new UsuallyGame();
            TrainGame trainGame = new TrainGame();
            OneRatingGame oneRatingGame = new OneRatingGame();
            
            var denis = new GameAccount("Denis");
            var artem = new GameAccount("Artem");
            
            var ivan = new HardAccount("Ivan");
            var vlad = new HardAccount("Vlad");

            var sasha = new BonusAccount("Sasha");
            var boris = new BonusAccount("Boris");

            denis.WinGame(artem, usuallyGame);
            denis.LoseGame(artem, usuallyGame);
            
            denis.WinGame(artem, oneRatingGame);
            denis.LoseGame(artem, oneRatingGame);
            
            sasha.WinGame(boris, trainGame);
            sasha.WinGame(boris, trainGame);
            sasha.WinGame(boris, trainGame);
            
            ivan.WinGame(vlad,usuallyGame);
            ivan.LoseGame(vlad,usuallyGame);

            CreateAccount createAccount = new CreateAccount(); 
            BonusAccount player1 = createAccount.BonusAccount();
            GameAccount player2 = createAccount.GameAccount();
            HardAccount player3 = createAccount.HardAccount();
            
            player1.WinGame(player2,usuallyGame);
            player1.LoseGame(player2,usuallyGame);
            
            player2.LoseGame(player3, usuallyGame);
            player2.LoseGame(player3, oneRatingGame);

            Account.HistoryGames();
            
            Console.WriteLine(denis.CurrentRating);
            Console.WriteLine(artem.CurrentRating);
            Console.WriteLine(sasha.CurrentRating);
            Console.WriteLine(boris.CurrentRating);
            Console.WriteLine(ivan.CurrentRating);
            Console.WriteLine(vlad.CurrentRating);
        }
    }
}