using System;

namespace Html
{
    public class MetaData :
        Element
    {
        protected override string TagName { get { return "meta"; } }
        public string Name { get; set; }
        public string Content { get; set; }
        public string CharacterSet { get; set; }
        public string HttpEquivalent { get; set; }
        
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("content", this.Content) +
                 this.FormatAttribute("charset", this.CharacterSet) +
                 this.FormatAttribute("http-equiv", this.HttpEquivalent);
        }
    }
}
