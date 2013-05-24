using System;
using Collection = Kean.Core.Collection;
using Kean.Core.Extension;


namespace Html
{
    public class Document
    {
        public Head Head{get; set;}
        public Body Body{get; set;}
       // public Attribute Attribute { get; set; }
        public Document()
        {
            this.Head = new Head();
            this.Body = new Body();
           // this.Attribute = new Attribute();
        }
        public bool Save(string filename)
        {
            System.IO.File.WriteAllText(filename, this.ToString());
            return true;
        }
        public override string ToString()
        {
            return "<!DOCTYP> <html> \n <html> \n" + this.Head.Format(1) + this.Body.Format(1) + "\n </html> \n" ;
        }

      
    }
}
