using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Bootcamp
{
    public class Ascent
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int MountainId { get; set; }
        public Mountain Mountain { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}