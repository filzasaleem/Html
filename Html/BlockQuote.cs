using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class BlockQuote :
        Element 
    {
        protected override string TagName{ get { return "blockquote"; } }
        public string Cite { get; set; }
        public BlockQuote()
        {
            this.NoLineBreaks = true;
        }
        public BlockQuote(string content) :
            this()
        {
            this.Add(new Text(content));
        }
        protected override string FormatAttributes()
        {
            string result =  base.FormatAttributes();
            if (Cite != null)
                result = result + " cite= \"" + this.Cite + "\"";
            return result;
        } 
    }
}
