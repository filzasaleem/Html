using System;

namespace Html
{
    public class TableHeading : 
        Element
    {
        protected override string TagName{ get {return "th"; } }
        #region Constructor
        public TableHeading()
        {
            this.NoLineBreaks = true;
        }
        public TableHeading(Node content)
        {
            this.Add(content);
        }
        public TableHeading(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
