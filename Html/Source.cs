using System;

namespace Html
{
    public class Source :
        Element
    {
        protected override string TagName { get { return "source"; } }
        public string Media { get; set; }
        public string Src { get; set; }
        public string Type { get; set; }
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("media", this.Media) +
                 this.FormatAttribute("src", this.Src) +
                 this.FormatAttribute("type", this.Type);
        }
    }
}
