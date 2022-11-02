using System;

namespace oopLr2
{
    public class Runner
    {
        static void Main()
        {
            var denis = new GameAccount("Denis");
            var artem = new GameAccount("Artem");
            
            var stas = new HardAccount("Stas");
            var vlad = new HardAccount("Vlad");

            var sasha = new BonusAccount("Sasha");
            var boris = new BonusAccount("Boris");

            denis.WinGame(artem, "Usually");
            denis.LoseGame(artem, "Usually");
            
            denis.WinGame(artem, "OneRating");
            denis.LoseGame(artem, "OneRating");
            
            sasha.WinGame(boris, "Train");
            sasha.WinGame(boris, "Train");
            sasha.WinGame(boris, "Train");
            
            stas.WinGame(vlad,"Usually");
            stas.LoseGame(vlad,"Usually");

            CreateAccount createAccount = new CreateAccount(); 
            BonusAccount player1 = createAccount.BonusAccount();
            GameAccount player2 = createAccount.GameAccount();
            HardAccount player3 = createAccount.HardAccount();
            
            player1.WinGame(player2,"Usually");
            player1.LoseGame(player2,"Usually");
            
            player2.LoseGame(player3, "Usually");
            player2.LoseGame(player3, "OneRating");

            Account.HistoryGames();
            
            Console.WriteLine(denis.CurrentRating);
            Console.WriteLine(artem.CurrentRating);
            Console.WriteLine(sasha.CurrentRating);
            Console.WriteLine(boris.CurrentRating);
            Console.WriteLine(stas.CurrentRating);
            Console.WriteLine(vlad.CurrentRating);
        }
    }
}