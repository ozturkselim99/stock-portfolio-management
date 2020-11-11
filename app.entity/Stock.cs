using System;
using System.Collections.Generic;
using System.Text;

namespace app.entity
{
    public class Stock
    {
        public double rate { get; set; }
        public double lastprice { get; set; }
        public string lastpricestr { get; set; }
        public double hacim { get; set; }
        public string hacimstr { get; set; }
        public string text { get; set; }
        public string code { get; set; }
        public double change { get; set; }
    }
}
