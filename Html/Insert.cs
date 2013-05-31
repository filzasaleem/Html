using System;

//The <ins> tag defines a text that has been inserted into a document.

namespace Html
{
    public class Insert :
        Element
    {
        protected override string TagName { get { return "ins"; } }
        public string Cite { get; set; }         //url to the document that explain the reason why the text was inserted
        public string DateTime { get; set; }     //Specifies the date and time of when the text was inserted/changed(YYYY-MM-DDThh:mm:ss)
        #region Constructor
        public Insert()
        {
            this.NoLineBreaks = true;
        }
        public Insert(Node content) :
            this()
        {
            this.Add(content);
        }
        public Insert(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("cite", this.Cite) +
                   this.FormatAttribute("datetime", this.DateTime);
        }
    }
}
