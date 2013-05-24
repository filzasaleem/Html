using System;

namespace Html
{
    public class Title :
        Element
    {
        protected override string Name { get { return "title"; } }
        public Title()
        { }
        public Title(string title)
        {
            this.Add(new Text(title));
        }
        public string Lang { get; set; }
        protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if (Lang != null)
                result = result + " lang =\"" + this.Lang + "\"";
            return result;
        }
    }
}
