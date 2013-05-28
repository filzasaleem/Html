using System;

namespace Html
{
    public class Head :
        Element 
    {
        protected override string TagName { get { return "head"; } }

        protected override string FormatAttributes()
        {
            return base.FormatAttributes();
        }
        
    }
}
