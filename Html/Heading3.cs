using System;

namespace Html
{
    public class Heading3 :
        Element
    {
        protected override string TagName { get { return "h3"; } }
        #region Constructor
        public Heading3()
        {
            this.NoLineBreaks = true;
        }
        public Heading3(Node content) :
            this()
        {
            this.Add(content);
        }
        public Heading3(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
