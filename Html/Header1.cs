using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Header1 :
        Element 
    {
        protected override string Name{ get { return "h1"; } }
         public Header1()
        {

        }
        public Header1(string content)
        {
            this.Add(new Text(content));
        }
        public string Class { get; set; }
        public string Title { get; set; }
        protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if (Class != null)
                result = result + " class =\"" + this.Class + "\"";
            if (Title != null)
                result = result + " title =\"" + this.Title + "\"";
            return result;
        }
    }
}
