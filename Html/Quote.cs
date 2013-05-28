using System;

namespace Html
{
    public class Quote :
        Element 
    {
        protected override string TagName { get { return "q"; } }
        public string Cite { get; set; }
        #region Constructor
        public Quote()
        {
            this.NoLineBreaks = true;
        }
        public Quote(Node content) :
            this()
        {
            this.Add(content);
        }
        public Quote(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("cite", this.Cite);
        } 
    }
}
