using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class Button : 
        Element 
    {
        protected override string TagName{ get { return "Button"; } }
         public Button()
        {

        }
        public Button(string content)
        {
            this.Add(new Text(content));
        }
        public string Nameb { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Onclick { get; set; }
        protected override string FormatAttributes()
        {
            string result = base.FormatAttributes();
            if (Nameb != null)
                result = result + " name =\"" + this.Nameb + "\"";
            if (Value  != null)
                result = result + " value =\"" + this.Value + "\"";
            if (Type != null)
                result = result + " type =\"" + this.Type + "\"";
            if (Onclick != null)
                result = result + " onclick =\"" + this.Onclick + "\"";
            return result;
        }
    }
}
