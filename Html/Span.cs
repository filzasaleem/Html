using System;

namespace Html
{
    public class Span :
        Element
    {
        protected override string TagName { get { return "span"; } }
        #region Constructor
        public Span()
        {
            this.NoLineBreaks = true;
        }
        public Span(Node content) :
            this()
        {
            this.Add(content);
        }
        public Span(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
