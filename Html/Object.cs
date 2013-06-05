using System;


namespace Html
{
    public class Object :
        Element
    {
        protected override string TagName { get { return "object"; } }
        public string Height { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string FormIdentifier { get; set; }
        public string UseMap { get; set; }
        public string Width { get; set; }
        public string Data { get; set; }
        #region Constructor
        public Object()
        {
            this.NoLineBreaks = true;
        }
        public Object(Node content) :
            this()
        {
            this.Add(content);
        }
        public Object(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() +
                this.FormatAttribute("form", this.FormIdentifier)+
                this.FormatAttribute("name", this.Name)+
                this.FormatAttribute("height", this.Height)+
                this.FormatAttribute("width", this.Width) +
                this.FormatAttribute("data", this.Data) +
                this.FormatAttribute("type", this.Type)+
                this.FormatAttribute("usemap", this.UseMap);
        }
    }
}
