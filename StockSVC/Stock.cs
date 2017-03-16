using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSVC
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string Date { get; set; }

        public long Volume { get; set; }
        public int Change { get; set; }

    }

    }
