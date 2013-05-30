using System;

//The <em> tag is a phrase tag. It renders as emphasized text. 

namespace Html
{
    public class Emphasized :
        Element
    {
        protected override string TagName { get { return "em"; } }
        #region Constructor
        public Emphasized()
        {
            this.NoLineBreaks = true;
        }
        public Emphasized(Node content) :
            this()
        {
            this.Add(content);
        }
        public Emphasized(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
