using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MFDBContainer context = new MFDBContainer();
            Customer cus = new Customer();
            //cus.CustomerName = "小明";
            //Customer cus1 = new Customer();
            //cus1.CustomerName = "小红";
            //OrderInfo info = new OrderInfo();
            //info.OrderContent = "手机";
            //OrderInfo info1 = new OrderInfo();
            //info1.OrderContent = "衣服";
            ////将用户和订单进行关联
            //cus.OrderInfoes.Add(info);
            //info1.Customer = cus1;
            //context.Customers.Add(cus);
            //context.Customers.Add(cus1);
            //context.OrderInfoes.AddRange(new List<OrderInfo> {info, info1});
            //context.SaveChanges();

            //context.SaveChanges();  

            //lambda表达式写分页 取部分列 如果不取部分列就不用select了
            var aa = context.Customers
                .Where(u => u.Id > 0)
                .OrderBy(u => u.Id)
                .Skip(5 * (2 - 1))
                .Take(5).Select(u => new { u.Id });
            //linq表达式分页并取部分值
            var bb = (from item in context.Customers
                      where item.Id > 1
                      orderby item.Id descending
                      select new { item.Id, item.CustomerName }).Skip(5 * (3 - 1)).Take(5);

            Console.WriteLine("完成了");
            Console.ReadKey();
        }
    }
}
