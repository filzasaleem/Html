using System;

namespace Html
{
    public class UnderLine :
        Element
    {
        protected override string TagName { get { return "u"; } }
        #region Constructor
        public UnderLine()
        {
            this.NoLineBreaks = true;
        }
        public UnderLine(Node content) :
            this()
        {
            this.Add(content);
        }
        public UnderLine(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
