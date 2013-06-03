using System;

namespace Html
{
    public class Mark :
        Element
    {
        protected override string TagName { get { return "mark"; } }
        #region Constructor
        public Mark()
        {
            this.NoLineBreaks = true;
        }
        public Mark(Node content) :
            this()
        {
            this.Add(content);
        }
        public Mark(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
