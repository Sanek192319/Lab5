using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class FiveDollars : MoneyHandler
    {
        public FiveDollars(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.banknote && money.value == MoneyValue.Value_500)
            {
                context.banknote_five++;
                context.sum += 5;
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
