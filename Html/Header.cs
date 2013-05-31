using System;

//The <header> tag specifies a header for a document or section.

namespace Html
{
    public class Header :
        Element
    {
        protected override string TagName { get { return "header"; } }
        #region Constructor
        public Header()
        {
            this.NoLineBreaks = true;
        }
        public Header(Node content) :
            this()
        {
            this.Add(content);
        }
        public Header(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
