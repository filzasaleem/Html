using System;

namespace Html
{
    public class Progress :
        Element
    {
        protected override string TagName { get { return "progress"; } }
        public string Maximum { get; set; }
        public string Value { get; set; }
        #region Constructor
        public Progress()
        {
            this.NoLineBreaks = true;
            this.RequiresEndTag = true;
        }
        public Progress(Node content) :
            this()
        {
            this.Add(content);
        }
        public Progress(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                this.FormatAttribute("value", this.Value) +
                this.FormatAttribute("max", this.Maximum);
        }
    }
}
