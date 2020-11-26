using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame.LoggerNS
{
    public class Logger
    {
        private static Logger logger;
        public List<string> Data { get; set; } = new List<string>();

        public static Logger CreateLogger()
        {
            if (logger == null) logger = new Logger(); 
            return logger;
        }

        private Logger()
        {

        }

        public void Log(string input)
        {
            Data.Add(input);
        }
    }
}
