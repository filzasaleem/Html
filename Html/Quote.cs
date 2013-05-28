using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class Quote :
        Element 
    {
        protected override string TagName { get { return "q"; } }
        public string Cite { get; set; }
        public Quote()
        {
        }
        public Quote(string content)
        {
            this.Add(new Text(content));
        }
        protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if (Cite != null)
                result = result + " cite= \"" + this.Cite + "\"";
            return result;
        } 
    }
}
