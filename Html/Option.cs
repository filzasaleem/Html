using System;

namespace Html
{
    public class Option :
        Element
    {
        protected override string TagName { get { return "option"; } }
        public string LabelForOption { get; set; }
        public string Disabled { get; set; }
        public string Selected { get; set; }
        public string Value { get; set; }
        #region Constructor
        public Option()
        {
            this.NoLineBreaks = true;
        }
        public Option(Node content) :
            this()
        {
            this.Add(content);
        }
        public Option(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("selected", this.Selected)+
                this.FormatAttribute("disabled", this.Disabled)+
                this.FormatAttribute("label", this.LabelForOption) +
                this.FormatAttribute("value", this.Value);
        }
    }
}
