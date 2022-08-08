using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntityForWeb.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int  PhoneNumber { get; set; }
        public Company? Company { get; set; }
        public Payment? Payment { get; set; }
    }
}
