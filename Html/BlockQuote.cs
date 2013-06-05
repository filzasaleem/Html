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
            return 
                 base.FormatAttributes()+
                 this.FormatAttribute("cite", this.Cite);
        } 
    }
}
