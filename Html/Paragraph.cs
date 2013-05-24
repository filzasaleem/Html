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
        //public override string Attribute(string name, string value)
        //{
        //    return name + " = " + value;
        //}
    }
    

}
