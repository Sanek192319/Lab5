using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Money
    {
        public MoneyType type { get; set; }
        public MoneyValue value { get; set; }
        public Money(MoneyType type, MoneyValue value)
        {
            this.type = type;
            this.value = value;
        }
    }
}
