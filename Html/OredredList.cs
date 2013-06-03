using System;

namespace Html
{
    public class OredredList :
        Element
    {
        protected override string TagName { get { return "ol"; } }
        public string Reversed { get; set; }
        public string StartValue { get; set; }
        public string TypeOfMarker { get; set; }
        #region Constructor
        public OredredList()
        {
            this.NoLineBreaks = true;
        }
        public OredredList(Node content) :
            this()
        {
            this.Add(content);
        }
        public OredredList(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("reversed", this.Reversed)+
                this.FormatAttribute("start", this.StartValue)+
                this.FormatAttribute("type", this.TypeOfMarker);
        }
    }
}
