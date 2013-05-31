using System;

namespace Html
{
    public class Label :
        Element
    {
        protected override string TagName { get { return "label"; } }
        public string For { get; set; }
        public string FormIdentifier { get; set; }
        #region Constructor
        public Label()
        {
            this.NoLineBreaks = true;
        }
        public Label(Node content) :
            this()
        {
            this.Add(content);
        }
        public Label(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("for", this.For) +
                 this.FormatAttribute("form", this.FormIdentifier);
        }
    }
}
