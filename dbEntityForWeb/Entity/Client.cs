using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntityForWeb.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long  PhoneNumber { get; set; }
        //[ForeignKey(nameof(Company))]
        //public int CurrentCompanyId { get; set; }
        //[ForeignKey(nameof(Payment))]
        public Company Company { get; set; }
        public Payment Payment { get; set; }
    }
}
