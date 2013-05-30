using System;

//It defines important text.

namespace Html
{
    public class Strong :
        Element
    {
        protected override string TagName { get { return "strong"; } }
        #region Constructor
        public Strong()
        {
            this.NoLineBreaks = true;
        }
        public Strong(Node content) :
            this()
        {
            this.Add(content);
        }
        public Strong(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
