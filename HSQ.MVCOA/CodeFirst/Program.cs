using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        /// <summary>
        /// 使用CodeFirst时，如果第一次创建生成了数据库，之后再增加实体类，直接执行的话，就会报异常，说是数据迁移问题。具体看看https://docs.microsoft.com/zh-cn/ef/ef6/modeling/code-first/migrations/index  这个是完整的EF教程
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CodeFirstDBContext dbcontext = new CodeFirstDBContext();
            dbcontext.Database.CreateIfNotExists();
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = "小明";
            userInfo.Email = "aaa";
            dbcontext.UserInfo.Add(userInfo);
            dbcontext.SaveChanges();
            Console.Write("成功");
            Console.ReadKey();
        }
    }
}
