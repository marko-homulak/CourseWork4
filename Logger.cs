using System;
using System.IO;

namespace BeeBearGUI
{
    public class FileLogger : ILogger
    {
        private static readonly object _lock = new object();
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            lock (_lock)
            {
                File.AppendAllText(_filePath, $"{DateTime.Now:HH:mm:ss} {message}{Environment.NewLine}");
            }
        }
    }

}
