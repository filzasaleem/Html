using System;

namespace Html
{
    public class Heading4 :
        Element
    {
        protected override string TagName { get { return "h4"; } }
        #region Constructor
        public Heading4()
        {
            this.NoLineBreaks = true;
        }
        public Heading4(Node content) :
            this()
        {
            this.Add(content);
        }
        public Heading4(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
