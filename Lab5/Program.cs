using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            MoneyHandler fifty = Calculate(context);
            Money fiftyBucks = new Money(MoneyType.banknote, MoneyValue.Value_5000);
            Money onehundred = new Money(MoneyType.banknote, MoneyValue.Value_10000);
            for (int i = 0; i < 2; i++)
            {
                fifty.Handle(fiftyBucks);
            }
            fifty.Handle(onehundred);
            Money fifty_coins = new Money(MoneyType.coin, MoneyValue.Value_50);
            for (int i = 0; i < 5; i++)
            {
                fifty.Handle(fifty_coins);
            }
            Money fivebucs = new Money(MoneyType.banknote, MoneyValue.Value_500);
            for (int i = 0; i < 3; i++)
            {
                fifty.Handle(fivebucs);
            }
            Console.WriteLine($"Total sum =  {context.sum} \n 100 dollars =  {context.banknote_onehundred} \n 50 dollars = {context.banknote_fifty}" +
                $"\n 20 dollars = {context.banknote_twenty} \n 10 dollars = {context.banknote_ten} \n 5 dollars = {context.banknote_five}" +
                $"\n 2 dollars = {context.banknote_two} \n 1 dollar = {context.banknote_one} \n 50 cents = {context.coin_fifty} \n five cents = {context.coin_five}" +
                $"\n 1 cent = {context.coin_one}");
        }
        public static MoneyHandler Calculate(Context context)
        {
            MoneyHandler five = new FiveDollars(context, null);
            MoneyHandler FiftyCoins = new FiftyCoins(context, five);
            MoneyHandler onehundler = new OneHundredDollars(context, FiftyCoins);
            MoneyHandler fifty = new FiftyDollars(context, onehundler);
           
            return fifty;
        }
    }
}
