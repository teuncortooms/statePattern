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
        public ObservableCollection<Item> Data { get; private set; } = new ObservableCollection<Item>();
        private object dataLock;

        public static Logger CreateLogger()
        {
            if (logger == null) logger = new Logger();
            return logger;
        }

        private Logger()
        {
            dataLock = new object();
        }

        public void Log(string input)
        {
            lock (dataLock)
            {
                //Data.Insert(0, input);
                Data.Add(new Item(input));
            }
            Console.WriteLine(input);
        }
    }
}
