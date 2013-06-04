using System;

namespace Html
{
    public class Details :
        Element
    {
        protected override string TagName { get { return "details"; } }
        public bool Open { get; set; }
        #region Constructor
        public Details()
        {
            this.NoLineBreaks = true;
            this.RequiresEndTag = true;
        }
        public Details(Node content) :
            this()
        {
            this.Add(content);
        }
        public Details(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("span", this.Open);
        }
    }
}
