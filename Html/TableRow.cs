using System;

namespace Html
{
    public class TableRow :
        Element 
    {
        protected override string TagName { get { return "tr"; } }
        #region Constructor
        public TableRow()
        {
        }
        public TableRow(Node content)
        {
            this.Add(content);
        }
        public TableRow(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
