using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class OneDollar : MoneyHandler
    {
        public OneDollar(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.banknote && money.value == MoneyValue.Value_100)
            {
                context.banknote_one++;
                context.sum += 1;
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
