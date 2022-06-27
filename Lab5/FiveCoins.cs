using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class FiveCoins : MoneyHandler
    {
        public FiveCoins(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.coin && money.value == MoneyValue.Value_5)
            {
                context.coin_five++;
                context.sum += 0.05f;
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
