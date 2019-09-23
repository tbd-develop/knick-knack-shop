using System;

namespace models
{
    public class KnickKnack
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal PricePaid { get; set; }
        public decimal Valuation { get; set; }
    }
}