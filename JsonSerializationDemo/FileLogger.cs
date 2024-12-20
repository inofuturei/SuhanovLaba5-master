using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializationDemo
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            System.IO.File.AppendAllText("log.txt", $"{message}\n");
        }
    }

}
