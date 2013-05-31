using System;

namespace Html
{
    public class Table :
        Element 
    {
        protected override string TagName {get { return "table"; }}
        public string Border { get; set; }
        #region Constructor
        public Table()
        {
            this.NoLineBreaks = true;
        }
        public Table(Node content) :
            this()
        {
            this.Add(content);
        }
        public Table(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("border", this.Border);
        }
    }
}
