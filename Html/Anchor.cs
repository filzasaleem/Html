using System;

namespace Html
{
    public class Anchor :
        Element
    {
        protected override string Name { get { return "a"; } }
        public string Destination { get; set; }
        public Anchor()
        {

        }
        public Anchor(string content)
        {
            this.Add(new Text(content));
        }
        protected override string FormatAttributes()
        {
            return base.FormatAttributes() + " href=\"" + this.Destination + "\"";
        }
    }
}
