using System;

namespace Html
{
    public class Script :
        Element
    {
        protected override string TagName { get { return "script"; } }
        public string Source { get; set; }
        public string CharacterSet { get; set; }
        public string Type { get; set; }
        public string Asynchronously { get; set; }
        public bool Defer { get; set; }
        #region Constructor
        public Script()
        {
            this.NoLineBreaks = true;
        }
        public Script(Node content) :
            this()
        {
            this.Add(content);
        }
        public Script(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() +
                this.FormatAttribute("src", this.Source)+
                this.FormatAttribute("charset", this.CharacterSet)+
                this.FormatAttribute("type", this.Type) +
                this.FormatAttribute("async", this.Asynchronously)+
                this.FormatAttribute("defer", this.Defer);
        }
    }
}
