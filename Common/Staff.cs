using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAservice.Common
{
    /// <summary>
    /// 员工类
    /// </summary>
    public class Staff:PersonBase
    {
        /// <summary>
        /// 分机号
        /// </summary>
        public string ExtNumber { get; set; }
        /// <summary>
        /// 企业QQ
        /// </summary>
        public string EntQQ { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public virtual Department Department { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime HireDate { get; set; }

    }
    /// <summary>
    /// 技术员技能等级
    /// </summary>
    public enum SkillRank
    {
        学徒,
        初级技术员一级,
        初级技术员二级,
        初级技术员三级,
        初级技术员四级,
        初级技术员五级,
        初级技术员六级,
        中级技术员一级,
        中级技术员二级,
        中级技术员三级,
        中级技术员四级,
        中级技术员五级,
        中级技术员六级,
        高级技术员一级,
        高级技术员二级,
        高级技术员三级,
        高级技术员四级,
        高级技术员五级,
        高级技术员六级,
        工程师一级,
        工程师二级,
        工程师三级,
        工程师四级,
        工程师五级,
        工程师六级,

    }
    /// <summary>
    /// 技术员类
    /// </summary>
    public class Technician : Staff
    {
        public SkillRank SkillRank { get; set; }
        /// <summary>
        /// 当前积分
        /// </summary>
        public int Credits { get; set; }
    }
}
