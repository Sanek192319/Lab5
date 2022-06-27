using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class FiftyDollars : MoneyHandler
    {
        public FiftyDollars(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.banknote && money.value == MoneyValue.Value_5000)
            { 
                context.banknote_fifty++;
                context.sum += 50;
            }



            else if (Successor != null)
            {
                Successor.Handle(money);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

    }
}
