using System;

namespace Html
{
    public class KeyGenerator :
        Element
    {
        protected override string TagName { get { return "keygen"; } }
        public string Challange { get; set; }
        public string FormIdentifier { get; set; }
        public string Name { get; set; }
        public string AutoFocus { get; set; }
        public string KeyType { get; set; }
        public string Disabled { get; set; }
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("challange", this.Challange) +
                 this.FormatAttribute("form", this.FormIdentifier) +
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("keytype", this.KeyType) +
                 this.FormatAttribute("autofocus", this.AutoFocus) +
                 this.FormatAttribute("disabled", this.Disabled);
        }
    }
}
