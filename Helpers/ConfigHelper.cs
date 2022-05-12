using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WPFGeneral.Helpers
{
    /// <summary>
    /// 配置助手
    /// </summary>
    class ConfigHelper
    {
        /// <summary>
        /// 获取配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings.Get(key);
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex.Message, ex);
                return null;
            }
        }
    }
}
