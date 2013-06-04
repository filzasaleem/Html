using System;

namespace Html
{
    public class Time :
        Element
    {
        protected override string TagName { get { return "time"; } }
        public string DateTime { get; set; }
        #region Constructor
        public Time()
        {
            this.NoLineBreaks = true;
        }
        public Time(Node content) :
            this()
        {
            this.Add(content);
        }
        public Time(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("datetime", this.DateTime);
        }
    }
}
