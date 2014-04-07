using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OAservice.Common
{
    /// <summary>
    /// 部门类
    /// </summary>
    public class Department
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
        public int? ParantID { get; set; }
        [Required]
        [Display(Name="部门名称")]
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 部门经理
        /// </summary>
        public virtual Staff DepartmentManager { get; set; }
        /// <summary>
        /// 导航属性,所属员工
        /// </summary>

        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
