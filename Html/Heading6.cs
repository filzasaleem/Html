using System;

namespace Html
{
    public class Heading6 :
        Element
    {
        protected override string TagName { get { return "h6"; } }
        #region Constructor
        public Heading6()
        {
            this.NoLineBreaks = true;
        }
        public Heading6(Node content) :
            this()
        {
            this.Add(content);
        }
        public Heading6(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
