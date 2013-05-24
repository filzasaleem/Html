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
        public string Id { get; set; }
        public string Dir { get; set; }
        public string Style { get; set; }


        public void Add(Node item)
        {
            this.childNodes.Add(item);
        }
        protected virtual string FormatAttributes()
        {
            string result = null;;
            if (Id != null)
                result = " id = \"" + this.Id + "\"" ;
            if (Dir != null)
                result = result + " dir=\"" + this.Id + "\"";
            if (Style != null)
                result = result + " style = \"" + this.Style + "\"";
            return result;
        }
        public override string Format(int indent)
        {
            return new string('\t', indent) + "<"  + this.Name +  this.FormatAttributes() +">\n" +
                this.childNodes.Fold((node, accumulator) => accumulator + node.Format(indent + 1), "") +
                new string('\t', indent) + "</" + this.Name + ">\n";
        }
       
      
    }
}
