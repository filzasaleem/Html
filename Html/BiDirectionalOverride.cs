using System;

namespace Html
{
    public class BiDirectionalOverride :
        Element
    {
        protected override string TagName { get { return "bdo"; } }
        public string Direction { get; set; }
        #region Constructor
        public BiDirectionalOverride()
        {
            this.NoLineBreaks = true;
        }
        public BiDirectionalOverride(Node content) :
            this()
        {
            this.Add(content);
        }
        public BiDirectionalOverride(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("dir", this.Direction);
                   
        } 
    }
}
