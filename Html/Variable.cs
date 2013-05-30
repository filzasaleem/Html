using System;

//It defines a variable

namespace Html
{
    public class Variable :
        Element 
    {
        protected override string TagName { get { return "var"; } }
        #region Constructor
        public Variable()
        {
            this.NoLineBreaks = true;
        }
        public Variable(Node content) :
            this()
        {
            this.Add(content);
        }
        public Variable(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
