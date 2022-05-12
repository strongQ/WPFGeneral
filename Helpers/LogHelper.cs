using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGeneral.Helpers
{
    /// <summary>
    /// 日志助手
    /// </summary>
    public class LogHelper
    {
        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");//这里的 loginfo 和 log4net.config 里的名字要一样
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");//这里的 logerror 和 log4net.config 里的名字要一样
        public static readonly log4net.ILog logheart = log4net.LogManager.GetLogger("logheart");//这里的 logerror 和 log4net.config 里的名字要一样

        /// <summary>
        /// 写心跳日志
        /// </summary>
        /// <param name="info"></param>
        public static void WriteLogHeart(string info)
        {
            if (logheart.IsInfoEnabled)
            {
                logheart.Info(info+Environment.NewLine);
            }
        }

        /// <summary>
        /// 写普通日志
        /// </summary>
        /// <param name="info"></param>
        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info + Environment.NewLine);
            }
        }

        /// <summary>
        /// 写异常日志
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ex"></param>
        public static void WriteLog(string info, Exception ex)
        {
           
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info+Environment.NewLine, ex);
            }
        }
        /// <summary>
        /// 写异常日志
        /// </summary>
        /// <param name="error"></param>
        public static void WriteLogEx(string error)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(error + Environment.NewLine);
            }
        }
    }
}
