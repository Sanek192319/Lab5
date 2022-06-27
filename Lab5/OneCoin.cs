using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class OneCoin : MoneyHandler
    {
        public OneCoin(Context context, MoneyHandler successor) : base(context, successor)
        {
        }
        public override void Handle(Money money)
        {
            if (money.type == MoneyType.coin && money.value == MoneyValue.Value_1)
            {
                context.coin_one++;
                context.sum += 0.01f;
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
