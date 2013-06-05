using System;

//<input> elements are used within a <form> element to declare input controls that allow users to input data.
//An input field can vary in many ways, depending on the type attribute.

namespace Html
{
    public class Input :
        Element
    {
        protected override string TagName { get { return "input"; } }
        public string Accept { get; set; }
        public string Alternate { get; set; }
        public string AutoComplete { get; set; }
        public bool AutoFocus { get; set; }
        public bool Checked { get; set; }
        public bool Disabled { get; set; }
        public bool ReadOnly { get; set; }
        public string FormIdentifier { get; set; }
        public string FormAction { get; set; }
        public string FormEncodedType { get; set; }
        public string FormMethod { get; set; }
        public string FormValidate { get; set; }
        public string FormTarget { get; set; }
        public string Height { get; set; }
        public string List { get; set; }
        public string MaximumValue { get; set; }
        public string MinimumValue { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Width { get; set; }
        public string Value { get; set; }
        public string Source { get; set; }
        public string Size { get; set; }
        public string Step { get; set; }
        public bool Required { get; set; }
        public string Multiple { get; set; }
        public string PlaceHolder { get; set; }
        public string Pattern { get; set; }
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("accept", this.Accept) +
                 this.FormatAttribute("alt", this.Alternate) +
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("autocomplete", this.AutoComplete) +
                 this.FormatAttribute("autofocus", this.AutoFocus) +
                 this.FormatAttribute("checked", this.Checked) +
                 this.FormatAttribute("disabled", this.Disabled) +
                 this.FormatAttribute("readonly", this.ReadOnly) +
                 this.FormatAttribute("form", this.FormIdentifier)+
                 this.FormatAttribute("formaction", this.FormAction) +
                 this.FormatAttribute("formenctype", this.FormEncodedType) +
                 this.FormatAttribute("formvalidate", this.FormValidate) +
                 this.FormatAttribute("formmethod", this.FormMethod) +
                 this.FormatAttribute("formtarget", this.FormTarget) +
                 this.FormatAttribute("height", this.Height) +
                 this.FormatAttribute("list", this.List) +
                 this.FormatAttribute("max", this.MaximumValue)+
                 this.FormatAttribute("min", this.MinimumValue) +
                 this.FormatAttribute("type", this.Type) +
                 this.FormatAttribute("autocomplete", this.AutoComplete) +
                 this.FormatAttribute("width", this.Width) +
                 this.FormatAttribute("value", this.Value) +
                 this.FormatAttribute("src", this.Source) +
                 this.FormatAttribute("size", this.Size)+
                 this.FormatAttribute("step", this.Step) +
                 this.FormatAttribute("required", this.Required) +
                 this.FormatAttribute("multiple", this.Multiple) +
                 this.FormatAttribute("placeholder", this.PlaceHolder) +
                 this.FormatAttribute("pattern", this.Pattern);

        }
    }
}
