using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Bootcamp
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Mountain> Mountains { get; set; } = new List<Mountain>();
    }
}