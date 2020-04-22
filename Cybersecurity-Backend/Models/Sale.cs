using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cybersecurity_Backend.Models
{
    public class Sale
    {
        public int saleId { get; set; }
        public int userId { get; set; }
        public string client_name { get; set; }
        public string company_name { get; set; }
        public string sale_conept { get; set; }
        public string sale_amount { get; set; }
        public DateTime sale_date { get; set; }
    }
}
