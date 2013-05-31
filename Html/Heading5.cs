using System;

namespace Html
{
    public class Heading5 :
        Element
    {
        protected override string TagName { get { return "h5"; } }
        #region Constructor
        public Heading5()
        {
            this.NoLineBreaks = true;
        }
        public Heading5(Node content) :
            this()
        {
            this.Add(content);
        }
        public Heading5(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
