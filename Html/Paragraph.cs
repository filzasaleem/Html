using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Paragraph :
        Element 
    {
        protected override string TagName { get { return "p"; } }
        #region Constructors
        public Paragraph()
        {
            this.NoLineBreaks = true;
        }
        public Paragraph(Node content) :
            this()
        {
            this.Add(content);
        }
        public Paragraph(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
