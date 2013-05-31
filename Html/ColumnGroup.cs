using System;

//The <colgroup> tag specifies a group of one or more columns in a table for formatting.
//The <colgroup> tag is useful for applying styles to entire columns, instead of repeating 
//the styles for each cell, for each row.

namespace Html
{
    public class ColumnGroup :
        Element
    {
        protected override string TagName { get { return "colgroup"; } }
        public string Span { get; set; }
        #region Constructor
        public ColumnGroup()
        {
            this.NoLineBreaks = true;
        }
        public ColumnGroup(Node content) :
            this()
        {
            this.Add(content);
        }
        public ColumnGroup(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("span", this.Span);
        }
    }
}
