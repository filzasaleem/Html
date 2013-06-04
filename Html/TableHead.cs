using System;

namespace Html
{
    public class TableHead :
        Element
    {
        protected override string TagName { get { return "thead"; } }
        #region Constructor
        public TableHead()
        {
            this.NoLineBreaks = true;
        }
        public TableHead(Node content) :
            this()
        {
            this.Add(content);
        }
        public TableHead(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
