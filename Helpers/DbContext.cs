using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGeneral.Helpers
{
    public class DbContext
    {
        //这里要public 
        public static SqlSugarScope Db = new SqlSugarScope(new ConnectionConfig()
        {
            DbType = SqlSugar.DbType.Oracle,
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString,
            IsAutoCloseConnection = true
        },
         db => {
             //单例参数配置，所有上下文生效
             db.Aop.OnLogExecuting = (s, p) =>
             {
                 Console.WriteLine(s);
             };
         });
    }
}
