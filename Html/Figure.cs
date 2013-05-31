using System;

//The <figure> tag specifies self-contained content, like illustrations, diagrams, photos, code listings, etc.
//While the content of the <figure> element is related to the main flow, its position is independent of the main
//flow, and if removed it should not affect the flow of the document.

namespace Html
{
    public class Figure :
        Element
    {
        protected override string TagName { get { return "figure"; } }
        #region Constructor
        public Figure()
        {
            this.NoLineBreaks = true;
        }
        public Figure(Node content) :
            this()
        {
            this.Add(content);
        }
        public Figure(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
