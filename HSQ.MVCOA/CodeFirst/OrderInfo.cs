using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class OrderInfo
    {
        public int Id { get; set; }
        public string OrderContent { get; set; }
        //导航属性
        public ICollection<UserInfo> UserInfo { get; set; }
    }
}
