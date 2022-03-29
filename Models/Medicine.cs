using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Bootcamp
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UseMethod { get; set; }
        public string Effects { get; set; }
        public string SideEffects { get; set; }
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}