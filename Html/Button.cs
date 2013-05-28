using System;

namespace Html
{
    public class Button : 
        Element 
    {
        protected override string TagName{ get { return "Button"; } }
         public Button()
        {
            this.NoLineBreaks = true;
        }
        public Button(string content) :
            this()
        {
            this.Add(new Text(content));
        }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Onclick { get; set; }
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("value", this.Value) +
                 this.FormatAttribute("type", this.Type) +
                 this.FormatAttribute("onclick", this.Onclick);
        }
    }
}
