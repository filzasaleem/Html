using System;

//The <embed> tag defines a container for an external application or interactive content (a plug-in).

namespace Html
{
    public class Embedded :
        Element
    {
        protected override string TagName { get { return "embed"; } }
        public string Height { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string Width { get; set; }
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("height", this.Height) +
                 this.FormatAttribute("type", this.Type) +
                 this.FormatAttribute("width", this.Width) +
                 this.FormatAttribute("src", this.Source);
        }
    }
}
