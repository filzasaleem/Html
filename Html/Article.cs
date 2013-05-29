using System;

namespace Html
{
    public class Article :
        Element
    {
        protected override string TagName { get { return "article"; } }
        #region Constructors
        public Article()
        {
            this.NoLineBreaks = true;
        }
        public Article(Node content) :
            this()
        {
            this.Add(content);
        }
        public Article(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
