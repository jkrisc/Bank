using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MultiLogger : ILogger
    {
        List<ILogger> loggers;

        public MultiLogger(List<ILogger> loggers)
        {
            this.loggers = loggers;
        }

        public void LogSuccess(string message)
        {
            foreach (ILogger logger in loggers)
            {
                logger.LogSuccess(message);
            }
        }

        public void LogError(string message)
        {
            foreach (ILogger logger in loggers)
            {
                logger.LogError(message);
            }
        }
    }
}
