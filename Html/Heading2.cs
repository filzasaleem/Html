using System;

namespace Html
{
    public class Heading2 :
        Element
    {
        protected override string TagName{ get { return "h2"; } }
        #region Constructor
        public Heading2()
        {
            this.NoLineBreaks = true;
        }
        public Heading2(Node content) :
            this()
        {
            this.Add(content);
        }
        public Heading2(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
