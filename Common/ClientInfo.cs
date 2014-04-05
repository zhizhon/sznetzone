using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAservice.Common
{
    public class ClientInfo:PersonBase
    {
        public string ClientName { get; set; }
        public string Telephone { get; set; } 
        public string Address { get; set; }
        public ClientStatus Status { get; set; }
    }
}
