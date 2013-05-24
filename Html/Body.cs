using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Body :
        Element 
    {
        protected override string Name { get {return "body"; } }
        public string BgColor { get; set; }
        public string Title { get; set; }
        protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if (BgColor != null)
                result = result + " bgcolor =\"" + this.BgColor + "\"";
            if (Title != null)
                result = result + " title =\"" + this.Title + "\"";
            return result;
       
        }
      
    }
}
