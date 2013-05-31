using System;

//The <dt> tag defines a term/name in a description list.
//The <dt> tag is used in conjunction with <dl> (defines a description list) and <dd> (describes each term/name).

namespace Html
{
    public class DefineTerm :
        Element
    {
        protected override string TagName { get { return "dt"; } }
        #region Constructor
        public DefineTerm()
        {
            this.NoLineBreaks = true;
        }
        public DefineTerm(Node content) :
            this()
        {
            this.Add(content);
        }
        public DefineTerm(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
