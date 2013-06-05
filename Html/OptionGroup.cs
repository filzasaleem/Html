using System;


namespace Html
{
    public class OptionGroup :
        Element
    {
        protected override string TagName { get { return "optgroup"; } }
        public string LabelForOption { get; set; }
        public bool Disabled { get; set; }
        #region Constructor
        public OptionGroup()
        {
            this.NoLineBreaks = true;
        }
        public OptionGroup(Node content) :
            this()
        {
            this.Add(content);
        }
        public OptionGroup(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() +
                this.FormatAttribute("label", this.LabelForOption) +
                this.FormatAttribute("disabled", this.Disabled);
        }
    }
}
