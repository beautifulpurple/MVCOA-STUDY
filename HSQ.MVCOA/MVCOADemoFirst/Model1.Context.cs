﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCOADemoFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVCOA_exerEntities : DbContext
    {
        public MVCOA_exerEntities()
            : base("name=MVCOA_exerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sheet> Sheets { get; set; }
        public virtual DbSet<Sys_Area> Sys_Area { get; set; }
        public virtual DbSet<Sys_DbBackup> Sys_DbBackup { get; set; }
        public virtual DbSet<Sys_FilterIP> Sys_FilterIP { get; set; }
        public virtual DbSet<Sys_Items> Sys_Items { get; set; }
        public virtual DbSet<Sys_ItemsDetail> Sys_ItemsDetail { get; set; }
        public virtual DbSet<Sys_Log> Sys_Log { get; set; }
        public virtual DbSet<Sys_Module> Sys_Module { get; set; }
        public virtual DbSet<Sys_ModuleButton> Sys_ModuleButton { get; set; }
        public virtual DbSet<Sys_ModuleForm> Sys_ModuleForm { get; set; }
        public virtual DbSet<Sys_ModuleFormInstance> Sys_ModuleFormInstance { get; set; }
        public virtual DbSet<Sys_Organize> Sys_Organize { get; set; }
        public virtual DbSet<Sys_Role> Sys_Role { get; set; }
        public virtual DbSet<Sys_RoleAuthorize> Sys_RoleAuthorize { get; set; }
        public virtual DbSet<Sys_User> Sys_User { get; set; }
        public virtual DbSet<Sys_User_Log> Sys_User_Log { get; set; }
        public virtual DbSet<Sys_UserLogOn> Sys_UserLogOn { get; set; }
        public virtual DbSet<Sys_WeChatUser> Sys_WeChatUser { get; set; }
        public virtual DbSet<T_Aactivitie> T_Aactivitie { get; set; }
        public virtual DbSet<T_AactSignup> T_AactSignup { get; set; }
        public virtual DbSet<T_Ballot> T_Ballot { get; set; }
        public virtual DbSet<T_Bill> T_Bill { get; set; }
        public virtual DbSet<T_Expenses> T_Expenses { get; set; }
        public virtual DbSet<T_Images> T_Images { get; set; }
        public virtual DbSet<T_MailBox> T_MailBox { get; set; }
        public virtual DbSet<T_News> T_News { get; set; }
        public virtual DbSet<T_Notice> T_Notice { get; set; }
        public virtual DbSet<T_OtherBill> T_OtherBill { get; set; }
        public virtual DbSet<T_PartyBuild> T_PartyBuild { get; set; }
        public virtual DbSet<T_PayResult> T_PayResult { get; set; }
        public virtual DbSet<T_Tenant> T_Tenant { get; set; }
        public virtual DbSet<T_Topic> T_Topic { get; set; }
        public virtual DbSet<T_TopicBack> T_TopicBack { get; set; }
        public virtual DbSet<T_Ver> T_Ver { get; set; }
        public virtual DbSet<T_Vote> T_Vote { get; set; }
        public virtual DbSet<T_LeaseRecord> T_LeaseRecord { get; set; }
    }
}
