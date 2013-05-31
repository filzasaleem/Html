using System;

//The <hgroup> tag is used to group heading elements.

namespace Html
{
    public class HeadingGroup :
        Element
    {
        protected override string TagName { get { return "hgroup"; } }
        #region Constructor
        public HeadingGroup()
        {
            this.NoLineBreaks = true;
        }
        public HeadingGroup(Node content) :
            this()
        {
            this.Add(content);
        }
        public HeadingGroup(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
