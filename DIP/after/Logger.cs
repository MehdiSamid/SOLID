using System;

namespace DIP.after
{
    public class Logger : ILogger
    {
        public void Log(string message, LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Info:
                    Console.WriteLine("[INFO] " + message);
                    break;
                case LogLevel.Warning:
                    Console.WriteLine("[WARNING] " + message);
                    break;
                case LogLevel.Error:
                    Console.WriteLine("[ERROR] " + message);
                    break;
                default:
                    throw new ArgumentException("Invalid log level");
            }
        }
    }

}
