using System;

namespace Html
{
    public class Link :
        Element
    {
        protected override string TagName { get { return "link"; } }
        public string Destination { get; set; }
        public string DestinationLanguage { get; set; }
        public string Relation { get; set; }
        public string Media { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        #region Constructor
        public Link()
        {
            this.NoLineBreaks = true;
        }
        public Link(Node content) :
            this()
        {
            this.Add(content);
        }
        public Link(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                this.FormatAttribute("href", this.Destination)+
                this.FormatAttribute("hreflang", this.DestinationLanguage)+
                this.FormatAttribute("rel", this.Relation)+
                this.FormatAttribute("media", this.Media)+
                this.FormatAttribute("size", this.Size)+
                this.FormatAttribute("type", this.Type);
        }
    }
}
