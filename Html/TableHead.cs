﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class TableHead : 
        Element
    {
        protected override string TagName{ get {return "th"; } }
        public TableHead()
        {
            this.NoLineBreaks = true;
        }
        public TableHead(string content)
        {
            this.Add(new Text(content));
        }
    }
}
