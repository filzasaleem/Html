using System;

namespace Html
{
    public class BidirectionalOverride :
        Element
    {
        protected override string TagName { get { return "bdo"; } }
        public string Direction { get; set; }
        #region Constructor
        public BidirectionalOverride()
        {
            this.NoLineBreaks = true;
        }
        public BidirectionalOverride(Node content) :
            this()
        {
            this.Add(content);
        }
        public BidirectionalOverride(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() +
                this.FormatAttribute("dir", this.Direction);
                   
        } 
    }
}
