using System;

namespace Html
{
    public class TableBody :
        Element
    {
        protected override string TagName { get { return "tbody"; } }
        #region Constructor
        public TableBody()
        {
            this.NoLineBreaks = true;
        }
        public TableBody(Node content) :
            this()
        {
            this.Add(content);
        }
        public TableBody(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
