using System;

//The <footer> tag defines a footer for a document or section.
//A <footer> element should contain information about its containing element.
//A footer typically contains the author of the document, copyright information, links to terms of use, contact information, etc.

namespace Html
{
    public class Footer :
        Element
    {
        protected override string TagName { get { return "footer"; } }
        #region Constructor
        public Footer()
        {
            this.NoLineBreaks = true;
        }
        public Footer(Node content) :
            this()
        {
            this.Add(content);
        }
        public Footer(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
