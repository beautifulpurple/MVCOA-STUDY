using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace OneContext
{
    /// <summary>
    /// 一次请求共用一个上下文实例的两种方法
    /// </summary>
    public class ContextHelper
    {
        //1.利用httpcontext  因为httpcontext已经保证了一次请求只有一个实例
        public MyDbContext GetCurrentContext_One()
        {
            MyDbContext context = HttpContext.Current.Items["MyDbContextOne"] as MyDbContext;
            if (context==null)
            {
                context = new MyDbContext();
                 HttpContext.Current.Items.Add("MyDbContextOne", context);
            }
            return context;
        }
        //2.利用callcontext
        public MyDbContext GetCurrentContext_Two()
        {
            MyDbContext context = CallContext.GetData("MyDbContextTwo") as MyDbContext;
            if (context==null)
            {
                context = new MyDbContext();
                CallContext.SetData("MyDbContextTwo", context);
            }
            return context;
        }
    }
    /// <summary>
    /// 模拟数据库上下文
    /// </summary>
    public class MyDbContext
    {

    }
}