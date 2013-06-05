using System;

namespace Html
{
    public class DataList :
        Element
    {
        protected override string TagName { get { return "datalist"; } }
        #region Constructor
        public DataList()
        {
        }
        public DataList(Node content)
        {
            this.Add(content);
        }
        public DataList(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
