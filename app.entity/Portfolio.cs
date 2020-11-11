using System;
using System.Collections.Generic;
using System.Text;

namespace app.entity
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string UserId { get; set; }
        public List<PortfolioItem> PortfolioItems { get; set; }
    }
}
