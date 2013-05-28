using System;

namespace Html
{
    public class Title :
        Element
    {
        protected override string TagName { get { return "title"; } }
        public Title()
        {
            this.NoLineBreaks = true;
        }
        public Title(string title) :
            this()
        {
            this.Add(new Text(title));
        }
        protected override string FormatAttributes()
        {
            return base.FormatAttributes();
        }
    }
}
