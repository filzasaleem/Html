using System;

//It defines keyboard input.
namespace Html
{
    public class KeyBoardInput :
        Element
    {
        protected override string TagName { get { return "kbd"; } }
        #region Constructor
        public KeyBoardInput()
        {
            this.NoLineBreaks = true;
        }
        public KeyBoardInput(Node content) :
            this()
        {
            this.Add(content);
        }
        public KeyBoardInput(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
