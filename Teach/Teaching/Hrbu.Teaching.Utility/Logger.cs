using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Hrbu.Teaching.Utility
{
    public class Logger
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger("EHR");

        static Logger()
        {
            var file = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config"));
            log4net.Config.XmlConfigurator.Configure(file);
        }
        /// <summary>
        /// Record infomation
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message, string context = "")
        {
            using (log4net.ThreadContext.Stacks["NDC"].Push(context))
            {
                log.Info(message);
            }
        }

        /// <summary>
        /// Recode system error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Error(string message, Exception exception, string context = "")
        {
            using (log4net.ThreadContext.Stacks["NDC"].Push(context))
            {
                log.Error(message, exception);
            }
        }
    }
}
