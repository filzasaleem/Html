using System;

using System.Threading.Tasks;

namespace Html
{
    public class TableData :
        Element
    {
        protected override string TagName { get { return "td"; } }
        #region Constructor
        public TableData()
        {
            this.NoLineBreaks = true;
        }
        public TableData(Node content) :
            this()
        {
            this.Add(content);
        }
        public TableData(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
