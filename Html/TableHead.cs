﻿using System;

namespace Html
{
    public class TableHead : 
        Element
    {
        protected override string TagName{ get {return "th"; } }
        #region Constructor
        public TableHead()
        {
            this.NoLineBreaks = true;
        }
        public TableHead(Node content)
        {
            this.Add(content);
        }
        public TableHead(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
