using System;

namespace Html
{
    public class HorizontalRule :
        Element
    {
        protected override string TagName { get { return "hr"; } }
        public HorizontalRule()
        {
            this.NoLineBreaks = true;
        }
    }
}
