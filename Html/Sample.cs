using System;

//It defines sample output from a computer program.

namespace Html
{
    public class Sample :
        Element
    {
        protected override string TagName { get { return "samp"; } }
        #region Constructor
        public Sample()
        {
            this.NoLineBreaks = true;
        }
        public Sample(Node content) :
            this()
        {
            this.Add(content);
        }
        public Sample(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
