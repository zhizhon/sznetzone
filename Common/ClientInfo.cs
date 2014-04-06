using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAservice.Common
{
    /// <summary>
    /// 客户类
    /// </summary>
    public class ClientInfo:PersonBase
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        public string ClientName { get; set; }
        public string Telephone { get; set; } 
        public string Address { get; set; }
        public ClientStatus Status { get; set; }
        public ClientRank Rank { get; set; }
    }
    public enum ClientRank
    {
        金牌VIP, //全包型
        银牌VIP, //周巡检
        铜牌VIP, //月巡检
        普通VIP, //免巡检，即时响应
        旧收费模式用户A, //有故障处理故障，免上门费，逐渐改变这种模式
        旧收费模式用户B, //有故障处理故障，免上门费，收来回路费，逐渐改变这种模式
        旧收费模式用户C, //有故障处理故障，收上门费，逐渐改变这种模式
        非网众用户, //非网众用户，但公司有卖硬件或其它软件！收上门费
    }
    public enum ClientStatus
    {
        正常营业,
        休业暂停,
        倒闭,

    }
}
