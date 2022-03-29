using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Bootcamp
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitPlace { get; set; }
        public string Diagnosis { get; set; }
        public string Recommendation { get; set; }
        public Medicine Medicine { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}