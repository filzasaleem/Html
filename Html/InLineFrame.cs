using System;

//An inline frame is used to embed another document within the current HTML document.

namespace Html
{
    public class InLineFrame :
        Element
    {
        protected override string TagName { get { return "iframe"; } }
        public string Height { get; set; }
        public string SandBox { get; set; }
        public string Name { get; set; }
        public string SeamLess { get; set; }
        public string Source { get; set; }
        public string Width { get; set; }
        public string SourceDocument { get; set; }
        #region Constructor
        public InLineFrame()
        {
            this.NoLineBreaks = true;
        }
        public InLineFrame(Node content) :
            this()
        {
            this.Add(content);
        }
        public InLineFrame(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("height", this.Height) +
                 this.FormatAttribute("sandbox", this.SandBox) +
                 this.FormatAttribute("name", this.Name) +
                 this.FormatAttribute("seamless", this.SeamLess) +
                 this.FormatAttribute("src", this.Source) +
                 this.FormatAttribute("width", this.Width) +
                 this.FormatAttribute("srcdoc", this.SourceDocument);
        }
    }
}
