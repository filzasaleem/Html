using System;

namespace Html
{
    public class Image :
        Element
    {
        protected override string TagName { get { return "img" ; } }
        public string Source { get; set; }
        public string Alternate { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("src", this.Source) +
                 this.FormatAttribute("alt", this.Alternate) +
                 this.FormatAttribute("height", this.Height) +
                 this.FormatAttribute("width", this.Width);
        }

    }
}
