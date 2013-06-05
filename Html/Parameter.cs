using System;

namespace Html
{
    public class Parameter :
        Element
    {
        protected override string TagName { get { return "param"; } }
        public string NameOfParameter { get; set; }
        public string ValueOfParameter { get; set; }
        #region Constructor
        public Parameter()
        {
            this.NoLineBreaks = true;
        }
        public Parameter(Node content) :
            this()
        {
            this.Add(content);
        }
        public Parameter(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() +
                this.FormatAttribute("name", this.NameOfParameter) +
                this.FormatAttribute("value", this.ValueOfParameter);
        }
    }
}
