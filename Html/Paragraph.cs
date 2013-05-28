using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Paragraph :
        Element 
    {
        protected override string TagName { get { return "P"; } }
        public Paragraph()
        {
            this.NoLineBreaks = true;
        }
        public Paragraph(string content) :
            this()
        {
            this.Add(new Text(content));
        }
        public Paragraph(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        public string Align { get; set; }
        protected override string FormatAttributes()
        {
            string result =  base.FormatAttributes();
            if (Align != null)
                result = result + " align =\"" + this.Align + "\"";
            return result;
        }
     }
    

}
