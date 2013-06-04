using System;

namespace Html
{
    public class UnorderedList :
        Element
    {
        protected override string TagName { get { return "ul"; } }
        #region Constructor
        public UnorderedList()
        {
            this.NoLineBreaks = true;
        }
        public UnorderedList(Node content) :
            this()
        {
            this.Add(content);
        }
        public UnorderedList(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
