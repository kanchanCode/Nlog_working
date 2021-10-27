using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace classwork_Nlog
{
   public class nlog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string input)
        {
            logger.Debug(input);
        }

        public void LogError(string input)
        {
            logger.Error(input);
        }

        public void LogWarn(string input)
        {
            logger.Warn(input);
        }

        public void LogInfo(string input)
        {
            logger.Info(input);
        }
    }
}

  
