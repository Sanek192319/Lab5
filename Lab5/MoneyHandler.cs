using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
   public abstract class MoneyHandler
    {
        protected Context context;
        public MoneyHandler Successor { get; set; }
        public MoneyHandler(Context context, MoneyHandler Successor)
        {
            this.context = context;
            this.Successor = Successor;
        }
        public abstract void Handle(Money money);
        protected void OnError(Money money)
        {
            Console.WriteLine($"no hadler for {money.type} with nominal {money.value}");
        }
    }
}
