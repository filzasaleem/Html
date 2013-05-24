using System;
using Collection = Kean.Core.Collection;
using Kean.Core.Collection.Extension;

namespace Html
{
    public abstract class Element: 
        Node
    {
        Collection.IList<Node> childNodes = new Collection.List<Node>();

        protected abstract string Name { get; }



        public void Add(Node item)
        {
            this.childNodes.Add(item);
        }
        protected virtual string FormatAttributes()
        {
            return "";
        }
        public override string Format(int indent)
        {
            return new string('\t', indent) + "<"  + this.Name +  this.FormatAttributes() +">\n" +
                this.childNodes.Fold((node, accumulator) => accumulator + node.Format(indent + 1), "") +
                new string('\t', indent) + "</" + this.Name + ">\n";
        }
       
      
    }
}
