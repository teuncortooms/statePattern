using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame.LoggerNS
{
    public class Logger
    {
        private static Logger logger;
        public ObservableCollection<string> Data { get; private set; } = new ObservableCollection<string>();

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
            Console.WriteLine(input);
        }
    }
}
