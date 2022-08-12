using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntityForWeb.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public bool Paid { get; set; }
        public double Contributed { get; set; }
        
    }
}
