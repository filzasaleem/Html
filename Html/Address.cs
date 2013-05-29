using System;

namespace Html
{
    public class Address :
        Element
    {
        protected override string TagName{ get { return "address"; } }
        #region Constructor
        public Address()
        {
            this.NoLineBreaks = true;
        }
        public Address(Node content) :
            this()
        {
            this.Add(content);
        }
        public Address(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
