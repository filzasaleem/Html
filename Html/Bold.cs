using System;

namespace Html
{
    public class Bold :
        Element 
    {
        protected override string TagName { get { return "b"; } }
        #region Constructor
        public Bold()
        {
        }
        public Bold(Node content)
        {
            this.Add(content);
        }
        public Bold(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
