using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class OneHundredDollars : MoneyHandler
    {
        public OneHundredDollars(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.banknote && money.value == MoneyValue.Value_10000)
            {
                context.banknote_onehundred++;
                context.sum += 100;
            }



            else if (Successor != null)
            {
                Successor.Handle(money);
            }
            else
            {
                OnError(money);
            }
        }

    }
}
