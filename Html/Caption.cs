using System;

namespace Html
{
    public class Caption :
        Element
    {
        protected override string TagName { get { return "caption"; } }
        #region Constructor
        public Caption()
        {
            this.NoLineBreaks = true;
        }
        public Caption(Node content) :
            this()
        {
            this.Add(content);
        }
        public Caption(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        
    }
}
