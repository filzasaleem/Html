using System;

namespace Html
{
    public class Table :
        Element 
    {
        protected override string TagName {get { return "table"; }}
        public string Border { get; set; }
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("border", this.Border);
        }
    }
}
