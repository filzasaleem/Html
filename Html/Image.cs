using System;

namespace Html
{
    public class Image :
        Element
    {
        protected override string TagName { get { return "img" ; } }
        public string Src { get; set; }
        public string Alt { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        protected override string FormatAttributes()
        {
            string result =  base.FormatAttributes();
            if (Src != null)
                result = result + " src = \"" + this.Src + "\"";
            if (Alt != null)
                result = result + " alt = \"" + this.Alt + "\"";
            if (Height != null)
                result = result + " height = \"" + this.Height + "\"";
            if (Width != null)
                result = result + " width = \"" + this.Width + "\"";
            return result;

        }

    }
}
