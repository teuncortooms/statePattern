using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame.LoggerNS
{
    public class Item
    {
        public Guid Id { get; private set; }
        public string Content { get; private set; }


        public Item(string content)
        {
            this.Id = Guid.NewGuid();
            this.Content = content;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
