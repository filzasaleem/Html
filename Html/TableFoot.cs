using System;

namespace Html
{
    public class TableFoot :
        Element 
    {
        protected override string TagName { get { return "tfoot"; } }
        #region Constructor
        public TableFoot()
        {
            this.NoLineBreaks = true;
        }
        public TableFoot(Node content) :
            this()
        {
            this.Add(content);
        }
        public TableFoot(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
