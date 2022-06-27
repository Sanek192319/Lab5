using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class TwoDollars : MoneyHandler
    {
        public TwoDollars(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.banknote && money.value == MoneyValue.Value_200)
            {
                context.banknote_two++;
                context.sum += 2;
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
