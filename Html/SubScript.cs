using System;

namespace Html
{
    public class SubScript :
        Element
    {
        protected override string TagName { get { return "sub"; } }
        #region Constructor
        public SubScript()
        {
            this.NoLineBreaks = true;
        }
        public SubScript(Node content) :
            this()
        {
            this.Add(content);
        }
        public SubScript(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
