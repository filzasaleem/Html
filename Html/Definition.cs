using System;

//It defines a definition term. 

namespace Html
{
    public class Definition :
        Element
    {
        protected override string TagName { get { return "dfn"; } }
        #region Constructor
        public Definition()
        {
            this.NoLineBreaks = true;
        }
        public Definition(Node content) :
            this()
        {
            this.Add(content);
        }
        public Definition(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
