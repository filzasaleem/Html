using System;

namespace Html
{
    public class TextArea :
        Element
    {
        protected override string TagName { get { return "textarea"; } }
        public string Row { get; set; }
        public string Column { get; set; }
        public string Name { get; set; }
        public string FormIdentifier { get; set; }
        public string Disabled { get; set; }
        public string MaximumLength { get; set; }
        public string Required { get; set; }
        public string ReadOnly { get; set; }
        public string Wrap { get; set; }
        public string AutoFocus { get; set; }
        public string PlaceHolder { get; set; }
        #region Constructor
        public TextArea()
        {
            this.NoLineBreaks = true;
        }
        public TextArea(Node content) :
            this()
        {
            this.Add(content);
        }
        public TextArea(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("form", this.FormIdentifier)+
                this.FormatAttribute("name", this.Name)+
                this.FormatAttribute("row", this.Row)+
                 this.FormatAttribute("col", this.Column)+
                this.FormatAttribute("disabled", this.Disabled)+
                this.FormatAttribute("required", this.Required)+
                 this.FormatAttribute("maxlength", this.MaximumLength)+
                this.FormatAttribute("readonly", this.ReadOnly)+
                this.FormatAttribute("wrap", this.Wrap)+
                 this.FormatAttribute("placeholder", this.PlaceHolder)+
                this.FormatAttribute("autofocus", this.AutoFocus);
        }
    }
}
