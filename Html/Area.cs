using System;

namespace Html
{
    public class Area :
        Element
    {
        protected override string TagName { get { return "area"; } }
        public string Alternate { get; set; }
        public string Coordinate { get; set; }
        public string Destination { get; set; }
        public string Media { get; set; }
        public string Relation { get; set; }
        public string Shape { get; set; }
        public string Target { get; set; }
        public string Type { get; set; }
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("alt", this.Alternate) +
                 this.FormatAttribute("coords", this.Coordinate) +
                 this.FormatAttribute("href", this.Destination) +
                 this.FormatAttribute("media", this.Media)+
                 this.FormatAttribute("rel", this.Relation)+
                 this.FormatAttribute("shape", this.Shape)+
                 this.FormatAttribute("target", this.Target)+
                 this.FormatAttribute("type", this.Type);
        }
    }
}
