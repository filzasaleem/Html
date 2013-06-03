using System;

namespace Html
{
    public class Output :
        Element
    {
        protected override string TagName { get { return "output"; } }
        public string NameOfOutput { get; set; }
        public string FormIdentifier { get; set; }
        public string For { get; set; }
        #region Constructor
        public Output()
        {
            this.NoLineBreaks = true;
        }
        public Output(Node content) :
            this()
        {
            this.Add(content);
        }
        public Output(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("form", this.FormIdentifier)+
                this.FormatAttribute("name", this.NameOfOutput)+
                this.FormatAttribute("for", this.For);
        }
    }
}
