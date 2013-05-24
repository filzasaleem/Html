using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class Title :
        Element
    {
        protected override string Name { get { return "title"; } }
        public Title()
        { }
        public Title(string title)
        {
            this.Add(new Text(title));
        }
    }
}
