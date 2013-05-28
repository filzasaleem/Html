using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Body :
        Element 
    {
        protected override string TagName { get {return "body"; } }
        protected override string FormatAttributes()
        {
            return base.FormatAttributes();
 ;
        }
      
    }
}
