using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class Bold :
        Element 
    {
        protected override string TagName { get { return "b"; } }
        public Bold()
        {
        }
        public Bold(string content)
        {
            this.Add(new Text(content));
        }
    }
}
