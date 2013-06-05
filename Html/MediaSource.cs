using System;

namespace Html
{
    public class MediaSource :
        Element
    {
        protected override string TagName { get { return "source"; } }
        public string Media { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("media", this.Media) +
                 this.FormatAttribute("src", this.Source) +
                 this.FormatAttribute("type", this.Type);
        }
    }
}
