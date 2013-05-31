using System;

//The <figcaption> tag defines a caption for a <figure> element.
//The <figcaption> element can be placed as the first or last child of the <figure> element.

namespace Html
{
    public class FigureCaption :
        Element
    {
        protected override string TagName { get { return "figcaption"; } }
        #region Constructor
        public FigureCaption()
        {
            this.NoLineBreaks = true;
        }
        public FigureCaption(Node content) :
            this()
        {
            this.Add(content);
        }
        public FigureCaption(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
