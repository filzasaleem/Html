using System;

namespace Html
{
    public class Head :
        Element 
    {
        protected override string Name { get { return "head"; } }
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
