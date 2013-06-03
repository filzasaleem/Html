using System;

//The <nav> tag defines a set of navigation links.
//Not all links of a document must be in a <nav> element. The <nav> element is intended only for major block of navigation links.

namespace Html
{
    public class NavigationLink :
        Element
    {
        protected override string TagName { get { return "nav"; } }
        #region Constructor
        public NavigationLink()
        {
            this.NoLineBreaks = true;
        }
        public NavigationLink(Node content) :
            this()
        {
            this.Add(content);
        }
        public NavigationLink(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
