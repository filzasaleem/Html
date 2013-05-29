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
        #region Constructor
        public BlockQuote()
        {
            this.NoLineBreaks = true;
        }
        public BlockQuote(Node content) :
            this()
        {
            this.Add(content);
        }
        public BlockQuote(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
         protected override string FormatAttributes()
        {
            string result =  base.FormatAttributes();
            if (Cite != null)
                result = result + " cite= \"" + this.Cite + "\"";
            return result;
        } 
    }
}
