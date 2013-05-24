using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Header1 :
        Element 
    {
        protected override string Name{ get { return "h1"; } }
         public Header1()
        {

        }
        public Header1(string content)
        {
            this.Add(new Text(content));
        }
    }
}
