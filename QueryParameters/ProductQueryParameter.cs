using System;

namespace Advanced_Web_API_dot_Net_6
{
    public class ProductQueryParameter:QueryParameters

    {
        public decimal?  MinPrice { get; set; }
        public decimal?  MaxPrice { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;

        public string  SearchTerm { get; set; }
    }
}

