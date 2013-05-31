using System;

//The <dl> tag defines a description list.
//The <dl> tag is used in conjunction with <dt> (defines terms/names) and <dd> (describes each term/name).

namespace Html
{
    public class DescriptionList :
        Element
    {
        protected override string TagName { get { return "dl"; } }
        #region Constructor
        public DescriptionList()
        {
            this.NoLineBreaks = true;
        }
        public DescriptionList(Node content) :
            this()
        {
            this.Add(content);
        }
        public DescriptionList(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
