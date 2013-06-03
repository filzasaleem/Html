using System;

namespace Html
{
    public class Map :
        Element
    {
        protected override string TagName { get { return "map"; } }
        public string Name { get; set; }
        #region Constructor
        public Map()
        {
            this.NoLineBreaks = true;
        }
        public Map(Node content) :
            this()
        {
            this.Add(content);
        }
        public Map(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return this.FormatAttribute("name", this.Name);
        }
    }
}
