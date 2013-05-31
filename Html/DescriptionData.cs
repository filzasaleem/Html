using System;

//The <dd> tag is used to describe a term/name in a description list.
//The <dd> tag is used in conjunction with <dl> (defines a description list) and <dt> (defines terms/names).
//Inside a <dd> tag you can put paragraphs, line breaks, images, links, lists, etc.

namespace Html
{
    public class DescriptionData :
        Element
    {
        protected override string TagName { get { return "dd"; } }
        #region Constructor
        public DescriptionData()
        {
            this.NoLineBreaks = true;
        }
        public DescriptionData(Node content) :
            this()
        {
            this.Add(content);
        }
        public DescriptionData(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
