using System;
using System.Collections.Generic;
using System.Text;

namespace app.entity
{
    public class PortfolioItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio portfolio { get; set; }
    }
}
