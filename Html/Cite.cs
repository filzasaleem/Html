using System;

//The <cite> tag defines the title of a work (e.g. a book, a song, a movie, a TV show, a painting, a sculpture, etc.)

namespace Html
{
    public class Cite :
        Element
    {
        protected override string TagName { get { return "cite"; } }
        #region Constructor
        public Cite()
        {
            this.NoLineBreaks = true;
        }
        public Cite(Node content) :
            this()
        {
            this.Add(content);
        }
        public Cite(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
