using System;

namespace Html
{
    public class ListItem :
        Element
    {
        protected override string TagName { get { return "li"; } }
        public string Value { get; set; }
        #region Constructor
        public ListItem()
        {
            this.NoLineBreaks = true;
        }
        public ListItem(Node content) :
            this()
        {
            this.Add(content);
        }
        public ListItem(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() + 
                this.FormatAttribute("value", this.Value);
        }
    }
}
