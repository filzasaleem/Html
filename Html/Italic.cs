using System;

namespace Html
{
    public class Italic :
        Element
    {
        protected override string TagName { get { return "i"; } }
        #region Constructor
        public Italic()
        {
            this.NoLineBreaks = true;
        }
        public Italic(Node content) :
            this()
        {
            this.Add(content);
        }
        public Italic(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
