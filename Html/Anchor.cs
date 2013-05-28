using System;

namespace Html
{
    public class Anchor :
        Element
    {
        protected override string TagName { get { return "a"; } }
        public string Destination { get; set; }
        #region Constructor
        public Anchor()
        {
        }
        public Anchor(string content)
        {
            this.Add(new Text(content));
        }
         public Anchor(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
         protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if(this.Destination != null)
                result = result + " href=\"" + this.Destination + "\"";
            return result;
        }
    }
}
