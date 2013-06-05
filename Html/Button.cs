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
        public bool AutoFocus { get; set; }
        public bool Disabled { get; set; }
        public string FormIdentifier { get; set; }
        public string FormAction { get; set; }
        public string FormMethod { get; set; }
        public string FormValidate { get; set; }
        public string FormTarget { get; set; }
        protected override string FormatAttributes()
        {
            return 
                 base.FormatAttributes()+
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("value", this.Value) +
                 this.FormatAttribute("type", this.Type) +
                 this.FormatAttribute("autofocus", this.AutoFocus)+
                 this.FormatAttribute("disabled", this.Disabled) +
                 this.FormatAttribute("form", this.FormIdentifier) +
                 this.FormatAttribute("formaction", this.FormAction) +
                 this.FormatAttribute("formmethod", this.FormMethod)+
                 this.FormatAttribute("formvalidate", this.FormValidate) +
                 this.FormatAttribute("formtarget", this.FormTarget);
        }
    }
}
