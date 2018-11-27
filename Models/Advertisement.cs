using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace umbrella.Models
{
    public class Advertisement
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public User user { get; set; }
    }
}
