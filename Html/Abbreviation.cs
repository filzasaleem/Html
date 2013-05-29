using System;

namespace Html
{
    public class Abbreviation :
        Element
    {
        protected override string TagName{ get { return "abbr"; } }
        #region Constructor
        public Abbreviation()
        {
            this.NoLineBreaks = true;
        }
        public Abbreviation(Node content) :
            this()
        {
            this.Add((content));
        }
        public Abbreviation(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
