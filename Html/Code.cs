using System;

//The <code> tag is a phrase tag. It defines a piece of computer code.

namespace Html
{
    public class Code :
        Element
    {
         protected override string TagName { get { return "code"; } }
        #region Constructor
        public Code()
        {
            this.NoLineBreaks = true;
        }
        public Code(Node content) :
            this()
        {
            this.Add(content);
        }
        public Code(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
