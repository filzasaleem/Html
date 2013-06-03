using System;

namespace Html
{
    public class PreFormattedText :
        Element
    {
        protected override string TagName { get { return "pre"; } }
        #region Constructor
        public PreFormattedText()
        {
            this.NoLineBreaks = true;
        }
        public PreFormattedText(Node content) :
            this()
        {
            this.Add(content);
        }
        public PreFormattedText(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
