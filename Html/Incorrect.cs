using System;

namespace Html
{
    public class Incorrect :
        Element
    {
        protected override string TagName { get { return "s"; } }
        #region Constructor
        public Incorrect()
        {
            this.NoLineBreaks = true;
        }
        public Incorrect(Node content) :
            this()
        {
            this.Add(content);
        }
        public Incorrect(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
