using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAservice.Common
{
    /// <summary>
    /// 部门类
    /// </summary>
    public class Department
    {
        public int id { get; }
        public int? ParantId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
    }
}
