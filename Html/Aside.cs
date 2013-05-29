using System;

namespace Html
{
    public class Aside :
        Element
    {
        protected override string TagName { get { return "aside"; } }
        #region Constructors
        public Aside()
        {
            this.NoLineBreaks = true;
        }
        public Aside(Node content) :
            this()
        {
            this.Add(content);
        }
        public Aside(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
