using System;

namespace Html
{
    public class SuperScript :
        Element
    {
        protected override string TagName { get { return "sup"; } }
        #region Constructor
        public SuperScript()
        {
            this.NoLineBreaks = true;
        }
        public SuperScript(Node content) :
            this()
        {
            this.Add(content);
        }
        public SuperScript(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}