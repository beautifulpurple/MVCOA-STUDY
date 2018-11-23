using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class UserInfo
    {
        public UserInfo()
        {
            OrderInfo = new HashSet<OrderInfo>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        //导航属性
        public virtual ICollection<OrderInfo> OrderInfo{get;set;}
    }
}
