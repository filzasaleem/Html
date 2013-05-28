using System;

namespace Html
{
    public class Title :
        Element
    {
        protected override string TagName { get { return "title"; } }
        #region Constructor
        public Title()
        {
            this.NoLineBreaks = true;
        }
        public Title(Node title) :
            this()
        {
            this.Add(title);
        }
        public Title(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return base.FormatAttributes();
        }
    }
}
