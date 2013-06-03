using System;

namespace Html
{
    public class Select :
        Element
    {
        protected override string TagName { get { return "select"; } }
        public string AutoFocus { get; set; }
        public string Disabled { get; set; }
        public string MultipleOption { get; set; }
        public string FormIdentifier { get; set; }
        public string NameOfList { get; set; }
        public string Required { get; set; }
        public string Size { get; set; }
        #region Constructor
        public Select()
        {
            this.NoLineBreaks = true;
        }
        public Select(Node content) :
            this()
        {
            this.Add(content);
        }
        public Select(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("form", this.FormIdentifier)+
                this.FormatAttribute("disabled", this.Disabled)+
                this.FormatAttribute("required", this.Required)+
                this.FormatAttribute("name", this.NameOfList)+
                this.FormatAttribute("multiple", this.MultipleOption)+
                this.FormatAttribute("size", this.Size)+
                this.FormatAttribute("autofocus", this.AutoFocus);
        }
    }
}
