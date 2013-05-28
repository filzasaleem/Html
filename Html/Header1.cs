﻿using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Header1 :
        Element 
    {
        protected override string TagName{ get { return "h1"; } }
        #region Constructor
        public Header1()
        {
            this.NoLineBreaks = true;
        }
        public Header1(Node content) :
            this()
        {
            this.Add(content);
        }
        public Header1(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
