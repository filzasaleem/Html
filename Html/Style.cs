using System;

namespace Html
{
    public class Style :
        Element
    {
        protected override string TagName { get { return "style"; } }
        public string Scoped { get; set; }
        public string Type { get; set; }
        public string Media { get; set; }
        #region Constructor
        public Style()
        {
            this.NoLineBreaks = true;
        }
        public Style(Node content) :
            this()
        {
            this.Add(content);
        }
        public Style(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("scoped", this.Scoped)+
                this.FormatAttribute("media", this.Media)+
                this.FormatAttribute("type", this.Type);
        }
    }
}
