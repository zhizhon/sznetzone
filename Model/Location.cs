using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szxlc.Model
{
    public class Location
    {
        
        public Guid PersonID { get; set; }
        //经度
        public string Longitude { get; set; }
        //纬度
        public string Latitude { get; set; }
        public DateTime DateTime { get; set; }
    }
}
