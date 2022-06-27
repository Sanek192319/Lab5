using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class TenDollars : MoneyHandler
    {
        public TenDollars(Context context, MoneyHandler successor ) : base(context,successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.banknote && money.value == MoneyValue.Value_1000)
            {
                context.banknote_ten++;
                context.sum += 10;
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
