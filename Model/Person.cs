using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Szxlc.Model
{
    #region 抽象类 Person
    public abstract class Person
    {
        public Guid PersonID { get; set; }
        public string Name { get; set; }
        public IList<string> MobilePhone { get; set; }
        public IList<string> QQ { get; set; }
        //当天位置轨迹
        public ICollection<Location> Locations { get; set; }
        public string Comment { get; set; }   //对人的备注
         //注册日期
        public DateTime RegDate { get; set; }
        //个人头像
        public Stream Avatar { get; set; }


        //当前状态--移到继承后补上
        //public PersonStatus Status { get; set; }


        //删除标记
        public bool Remove { get; set; }
        //删除时间
        public DateTime RemoveTime { get; set; }

    }
    #endregion


    #region 员工类--继承Person
    public class PersonStaff:Person   //继承Person类，员工类
    {
        //入职时间
        public string EntryDate { get; set; }
        //职务
        public string JobTitle { get; set; }
        //积分
        public int Credits { get; set; }
        public StaffStatus Status { get; set; }
        public Department Department { get; set; }
    }
    #endregion

    #region 客人类--继承Person
    public class PersonClient:Person
    {
        public ClientStatus ClientStatus { get; set; }
    }
    #endregion

    //员工状态
    public enum StaffStatus
    {
        待命中,
        外派中,
        病假中,
        年假中,
        事假中,
        出差中,
        值班中
    }

    //客人状态
    public enum ClientStatus
    {
        正常合作,
        已消失,
        退出行业终止合作,
        由于纠纷终止合作
    }

    //人所处位置
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
