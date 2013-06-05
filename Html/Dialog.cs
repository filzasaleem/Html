using System;

namespace Html
{
    public class Dialog :
        Element
    {
        protected override string TagName { get { return "dialog"; } }
        public bool Open { get; set; }
        #region Constructor
        public Dialog()
        {
        }
        public Dialog(Node content)
        {
            this.Add(content);
        }
        public Dialog(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() + 
                this.FormatAttribute("open", this.Open);
        }
    }
}
