using System;
using System.IO;

namespace Calculator.Sources
{
    class Logger
    {
        public void Log(String logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry\n");
            w.WriteLine($"Date: {DateTime.Now.ToLongTimeString()}\nTime: {DateTime.Now.ToLongDateString()}");
            w.WriteLine($"Message: {logMessage}");
            w.WriteLine("--------------------------------------------");
        }
        public void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
