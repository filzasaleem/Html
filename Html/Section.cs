using System;

//The <section> tag defines sections in a document. Such as chapters, headers, footers, or any other sections of the document.

namespace Html
{
    public class Section :
        Element
    {
        protected override string TagName { get { return "section"; } }
        #region Constructor
        public Section()
        {
            this.NoLineBreaks = true;
        }
        public Section(Node content) :
            this()
        {
            this.Add(content);
        }
        public Section(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
