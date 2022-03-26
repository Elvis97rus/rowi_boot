using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Bootcamp
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Climber> Climbers { get; set; } = new List<Climber>();
        public ICollection<Ascent> Ascents { get; set; } = new List<Ascent>();
    }
}