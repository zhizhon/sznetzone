using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OAservice.Common;

namespace OAservice.DAL
{
    public class SznetzoneInitializer:DropCreateDatabaseIfModelChanges<SznetzoneContext>
    {
        protected override void Seed(SznetzoneContext context)
        {
            //部门种子
            var Departments = new List<Department> {
                new Department{DepartmentName="总经办",DepartmentID=0},
                new Department{DepartmentName="技术部",DepartmentID=1},
                new Department{DepartmentName="业务部",DepartmentID=2}
            };
            Departments.ForEach(d=>context.Departments.Add(d));
            context.SaveChanges();

            //员工种子
            var Staffs = new List<Staff> {
                new Staff{DepartmentID=0,Name="余雷" },
                new Staff{DepartmentID=1,Name="陈广渝" },
                new Staff{DepartmentID=2,Name="陈秀基" },
            };
            Staffs.ForEach(s => context.Staffs.Add(s));
            context.SaveChanges();
            //客户种子
            var Clients = new List<ClientInfo>{
                new ClientInfo{ClientName="风云战线五分店"},
                new ClientInfo{ClientName="创世纪南昌店"},
                new ClientInfo{ClientName="旭新网吧"},
                new ClientInfo{ClientName="捷坤网吧一分店"},
                new ClientInfo{ClientName="蓝宝石网吧"},
                new ClientInfo{ClientName="创天下任我行店"},
                new ClientInfo{ClientName="佳缘网吧鹤坑店"},
            };
            Clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();


            base.Seed(context);
        }
    }
}