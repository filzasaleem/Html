using System;

namespace Html
{
    public class Heading1 :
        Element 
    {
        protected override string TagName{ get { return "h1"; } }
        #region Constructor
        public Heading1()
        {
            this.NoLineBreaks = true;
        }
        public Heading1(Node content) :
            this()
        {
            this.Add(content);
        }
        public Heading1(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
