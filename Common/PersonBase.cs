using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAservice.Common
{
    /// <summary>
    /// 用户基类
    /// </summary>
    public class PersonBase
    {
        //[key]
        public Guid id { get; }
        public string Name { get; set; }
        public string HandPhone { get; set; }
        public string QQ { get; set; }
        //位置
        public Location Location { get; set; }
        //备注
        public string Description { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginTime { get; }
        public bool IsOnline { get; set; }
    }
    public class Location
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
