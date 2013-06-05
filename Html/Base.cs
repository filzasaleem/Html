using System;

namespace Html
{
    public class Base :
        Element
    {
        protected override string TagName { get { return "base"; } }
        public string Destination { get; set; }
        public string Target { get; set; }
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("href", this.Destination) +
                 this.FormatAttribute("target", this.Target);
        }
    }
}
