using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public class Body :
        Element 
    {
        protected override string Name { get {return "body"; } }
        //public override string Attribute(string name, string value)
        //{
        //    return name + " = " + value;
        //}
      
    }
}
