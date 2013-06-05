using System;

//The <del> tag defines text that has been deleted from a document.

namespace Html
{
    public class Deleted :
        Element
    {
        protected override string TagName { get { return "del"; } }
        public string Cite { get; set; }         //url to the document that explain the reason why the text was deleted
        public string DateTime { get; set; }     //Specifies the date and time of when the text was deleted(YYYY-MM-DDThh:mm:ss)
        #region Constructor
        public Deleted()
        {
            this.NoLineBreaks = true;
        }
        public Deleted(Node content) :
            this()
        {
            this.Add(content);
        }
        public Deleted(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() + 
                this.FormatAttribute("cite", this.Cite) +
                this.FormatAttribute("datetime", this.DateTime);
        }
    }
}
