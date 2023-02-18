using System;
using System.ComponentModel.DataAnnotations;

namespace FlowersMvc.Models
{
    public class Flowers
    {
        public int Id { get; set; }
        public string ScientificName { get; set; }
        public string Color { get; set; }
        public string BloomingSeason { get; set; }
        public string Size { get; set; }
        public string Fragrance { get; set; }
        public string GrowingConditions { get; set; }
    }
}
