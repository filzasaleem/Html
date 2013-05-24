using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Paragraph:
        Element 
    {
        protected override string Name { get { return "P"; } }
        public Paragraph()
        {

        }
        public Paragraph(string content)
        {
            this.Add(new Text(content));
        }
        public string Align { get; set; }
        public string Title { get; set; }
        protected override string FormatAttributes()
        {
            string result =  base.FormatAttributes();
            if (Align != null)
                result = result + " align =\"" + this.Align + "\"";
            if (Title != null)
                result = result + " title =\"" + this.Title + "\"";
            return result;
        }
     }
    

}
