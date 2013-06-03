using System;

//The <legend> tag defines a caption for the <fieldset> element.

namespace Html
{
    public class Legend :
        Element
    {
        protected override string TagName { get { return "legend"; } }
        #region Constructor
        public Legend()
        {
            this.NoLineBreaks = true;
        }
        public Legend(Node content) :
            this()
        {
            this.Add(content);
        }
        public Legend(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
