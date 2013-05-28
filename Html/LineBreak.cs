using System;

namespace Html
{
    public class LineBreak :
        Element
    {
        protected override string TagName { get { return "br"; } }
        public LineBreak()
        {
            this.NoLineBreaks = true;
        }
    }
}
