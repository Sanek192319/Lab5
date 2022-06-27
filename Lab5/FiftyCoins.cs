using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class FiftyCoins : MoneyHandler
    {
        public FiftyCoins(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.coin && money.value == MoneyValue.Value_50)
            {
                context.coin_fifty++;
                context.sum += 0.5f;
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
