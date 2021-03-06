﻿using System;

namespace Html
{
    public class PreformattedText :
        Element
    {
        protected override string TagName { get { return "pre"; } }
        #region Constructor
        public PreformattedText()
        {
            this.NoLineBreaks = true;
        }
        public PreformattedText(Node content) :
            this()
        {
            this.Add(content);
        }
        public PreformattedText(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
    }
}
