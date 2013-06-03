using System;

//The <noscript> tag is used to provide an alternate content for users that have disabled 
//scripts in their browser or have a browser that doesn’t support client-side scripting.
//The <noscript> element can contain all the elements that you can find inside the <body>
//element of a normal HTML page.The content inside the <noscript> element will only be 
//displayed if scripts are not supported, or are disabled in the user’s browser.

namespace Html
{
    public class NoScript :
        Element
    {
        protected override string TagName { get { return "noscript"; } }
        #region Constructor
        public NoScript()
        {
            this.NoLineBreaks = true;
        }
        public NoScript(Node content) :
            this()
        {
            this.Add(content);
        }
        public NoScript(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
