using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCOADemoFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.声明一个EF的上下文
            MVCOA_exerEntities dbcontext = new MVCOA_exerEntities();
            //2.声明一个user实体
            //Sys_WeChatUser user = new Sys_WeChatUser();
            //user.F_Id = Guid.NewGuid().ToString();
            //user.WeChatName = "微信名6";
            //user.Name = "小明1";
            //user.Sex = "女";
            //user.Sha1OpenId = "099c3da6-c8f8-4f48-8939-d6c3aad3c7ba";

            ////3.告诉EF咱们对上面的实体做一个插入操作
            ////dbcontext.Sys_WeChatUser.Add(user);//增加操作
            //dbcontext.Sys_WeChatUser.Attach(user);
            ////dbcontext.Entry(user).State = EntityState.Modified;//对整个类进行操作  没赋值的话  自动更新W为NULL
            ////单独更新某列  不指名某列话 默认为false  不进行更新
            //dbcontext.Entry(user).Property(u => u.WeChatName).IsModified = true;
            ////4.告诉上下文把实体的变化保存到数据库
            //dbcontext.SaveChanges();
            //Console.WriteLine("成功了！！！");
            //List<string> aa = new List<string>() { "a", "b" };
            //aa.ForEach(Console.WriteLine);
            //查询
            foreach (var u in dbcontext.Sys_WeChatUser)
            {
                Console.WriteLine(u.WeChatName);
            }
            //linq表达式 读link 
            var entitys = from u in dbcontext.Sys_WeChatUser
                          where u.WeChatName !="aaa"
                          select u;
            // Expression<Func<int, bool>> 和 Func<int, bool>的区别
            Expression<Func<int, bool>> exp = a => a > 1;
            Func<int, bool> func = a =>
            {
                a += 2;
                return a > 1;
            };
            Console.ReadKey();

         
        }
    }
}
