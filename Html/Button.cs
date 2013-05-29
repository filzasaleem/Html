using System;

namespace Html
{
    public class Button : 
        Element 
    {
        protected override string TagName{ get { return "Button"; } }
        #region Constructor
        public Button()
        {
            this.NoLineBreaks = true;
        }
        public Button(Node content) :
            this()
        {
            this.Add(content);
        }
        public Button(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
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
