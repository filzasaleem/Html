using System;

namespace Html
{
    public class Table :
        Element 
    {
        protected override string Name {get { return "table"; }}
        public string Bgcolor { get; set; }
        public string Border { get; set; }
        public string Cellpadding { get; set; }
        public string Cellspacing { get; set; }
        public string Align { get; set; }
        protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if (Bgcolor  != null)
                result = result + " bgcolor =\"" + this.Bgcolor + "\"";
            if (Border != null)
                result = result + " border =\"" + this.Border + "\"";
            if (Cellpadding  != null)
                result = result + " cellpadding =\"" + this.Cellpadding + "\"";
            if (Cellspacing != null)
                result = result + " cellspacing =\"" + this.Cellspacing + "\"";
            if (Align != null)
                result = result + " align =\"" + this.Align + "\"";
            return result;
        }
    }
}
