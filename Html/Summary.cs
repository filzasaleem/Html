using System;

namespace Html
{
    public class Summary :
        Element
    {
        protected override string TagName { get { return "summary"; } }
        #region Constructor
        public Summary()
        {
            this.NoLineBreaks = true;
        }
        public Summary(Node content) :
            this()
        {
            this.Add(content);
        }
        public Summary(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
