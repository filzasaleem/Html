using System;

namespace Html
{
    public class Small :
        Element
    {
        protected override string TagName { get { return "small"; } }
        #region Constructor
        public Small()
        {
            this.NoLineBreaks = true;
        }
        public Small(Node content) :
            this()
        {
            this.Add(content);
        }
        public Small(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
