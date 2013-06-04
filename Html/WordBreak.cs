using System;

namespace Html
{
    public class WordBreak :
        Element
    {
        protected override string TagName { get { return "wbr"; } }
        #region Constructor
        public WordBreak()
        {
            this.NoLineBreaks = true;
        }
        public WordBreak(Node content) :
            this()
        {
            this.Add(content);
        }
        public WordBreak(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
