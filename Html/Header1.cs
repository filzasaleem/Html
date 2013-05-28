using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Header1 :
        Element 
    {
        protected override string TagName{ get { return "h1"; } }
        public Header1()
        {
            this.NoLineBreaks = true;
        }
        public Header1(string content) :
            this()
        {
            this.Add(new Text(content));
        }
    }
}
