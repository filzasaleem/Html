using System;

namespace Html
{
    public class Anchor :
        Element
    {
        protected override string TagName { get { return "a"; } }
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
            string result = base.FormatAttributes();
            if(this.Destination != null)
                result = result + " href=\"" + this.Destination + "\"";
            return result;
        }
    }
}
