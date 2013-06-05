using System;

//The <form> tag is supported in all major browsers.

namespace Html
{
    public class Form :
        Element
    {
        protected override string TagName { get { return "form"; } }
        public string Action { get; set; }
        public string Method { get; set; }
        public string Name { get; set; }
        public string AutoComplete { get; set; }
        public string Target { get; set; }
        public string NoValidate { get; set; }
        public string EnCodedType { get; set; }
        public string AcceptCharacterSet { get; set; }
        #region Constructor
        public Form()
        {
            this.NoLineBreaks = true;
        }
        public Form(Node content) :
            this()
        {
            this.Add(content);
        }
        public Form(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("action", this.Action) +
                 this.FormatAttribute("method", this.Method) +
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("autocomplete", this.AutoComplete) +
                 this.FormatAttribute("target", this.Target) +
                 this.FormatAttribute("novalidate", this.NoValidate) +
                 this.FormatAttribute("enctype", this.EnCodedType) +
                 this.FormatAttribute("accept-charset", this.AcceptCharacterSet);

        }
    }
}
