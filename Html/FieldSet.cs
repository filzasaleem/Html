using System;

//The <fieldset> tag is used to group related elements in a form.
//The <fieldset> tag draws a box around the related elements.

namespace Html
{
    public class FieldSet :
        Element
    {
        protected override string TagName { get { return "fieldset"; } }
        public bool Disabled { get; set; }
        public string Form { get; set; }
        public string Name { get; set; }
        #region Constructor
        public FieldSet()
        {
            this.NoLineBreaks = true;
        }
        public FieldSet(Node content) :
            this()
        {
            this.Add(content);
        }
        public FieldSet(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("disabled", this.Disabled) +
                 this.FormatAttribute("form", this.Form) +
                 this.FormatAttribute("name", this.Name);
        }
    }
}
