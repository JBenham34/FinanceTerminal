using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTerminal.Securities
{
    interface ISecurity
    {
        public string Symbol { get; }
        public string Name { get; }
    }
}
