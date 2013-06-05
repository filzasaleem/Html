using System;

namespace Html
{
    public class Anchor :
        Element
    {
        protected override string TagName { get { return "a"; } }
        public string Destination { get; set; }
        #region Constructor
        public Anchor()
        {
        }
        public Anchor(Node content)
        {
            this.Add(content);
        }
        public Anchor(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() + 
                this.FormatAttribute("href", this.Destination);
        }
    }
}
