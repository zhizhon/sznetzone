using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OAservice.Common
{
    /// <summary>
    /// 用户基类
    /// </summary>
    public class PersonBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PersonID { get; set; }
        [Required]
        [Display(Name="姓名")]
        public string Name { get; set; }
        public string HandPhone { get; set; }
        public string QQ { get; set; }
        //位置
        [Display(Name="当然位置")]
        public Location Location { get; set; }
        //备注
        public string Description { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginTime { get; set; }
        //是否在线，没必要加入数据库
        //public bool IsOnline { get; set; }
    }
    public class Location
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
