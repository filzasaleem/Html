using System;

//The <col> tag specifies column properties for each column within a <colgroup> element.
//The <col> tag is useful for applying styles to entire columns, instead of repeating the 
//styles for each cell, for each row.

namespace Html
{
    public class Column :
        Element
    {
        protected override string TagName { get { return "col"; } }
        public string Span { get; set; }
       
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("span", this.Span);
        }
    }
}
