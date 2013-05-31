using System;

//The <div> tag defines a division or a section in an HTML document.
//The <div> tag is used to group block-elements to format them with CSS.


namespace Html
{
    public class Division :
        Element
    {
        protected override string TagName { get { return "div"; } }
        #region Constructor
        public Division()
        {
            this.NoLineBreaks = true;
        }
        public Division(Node content) :
            this()
        {
            this.Add(content);
        }
        public Division(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
