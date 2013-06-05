using System;

namespace Html
{
    public class Canvas :
        Element
    {
        protected override string TagName { get { return "canvas"; } }
        public string Height { get; set; }         
        public string Width { get; set; }     
        #region Constructor
        public Canvas()
        {
            this.NoLineBreaks = true;
            this.RequiresEndTag = true;
        }
        public Canvas(Node content) :
            this()
        {
            this.Add(content);
        }
        public Canvas(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                   base.FormatAttributes() +
                   this.FormatAttribute("height", this.Height) +
                   this.FormatAttribute("width", this.Width);
        }
    }
}
