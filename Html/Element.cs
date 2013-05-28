using System;
using Collection = Kean.Core.Collection;
using Kean.Core.Collection.Extension;
using Kean.Core.Extension;

namespace Html
{
    public abstract class Element: 
        Node,
        System.Collections.Generic.IEnumerable<Node>
    {
        Collection.IList<Node> childNodes = new Collection.List<Node>();

        public bool Empty { get { return this.childNodes.Count == 0; } }

        protected abstract string TagName { get; }
        protected bool NoLineBreaks { get; set; }
        public string Identifier { get; set; }
        public string Direction { get; set; }
        public string Class { get; set; }
        public string Title { get; set; }
        public string Style { get; set; }
        public string Language { get; set; }
        public bool SpellCheck { get; set; }
        public bool ContentEditable { get; set; }

        public void Add(Node node)
        {
            this.childNodes.Add(node);
        }
        public void Add(params Node[] nodes)
        {
            this.childNodes.Add(nodes);
        }
        protected virtual string FormatAttributes()
        {
            return
                this.FormatAttribute("id", this.Identifier) +
                this.FormatAttribute("dir", this.Direction) +
                this.FormatAttribute("title", this.Title) +
                this.FormatAttribute("style", this.Style) +
                this.FormatAttribute("class", this.Class) +
                this.FormatAttribute("lang", this.Language) +
                this.FormatAttribute("spellcheck", this.SpellCheck) +
                this.FormatAttribute("contenteditable", this.ContentEditable);
        }
        protected string FormatAttribute<T>(string name, T value, T @default)
        {
            return value.SameOrEquals(@default) ? "" : " " + name + "=\"" + value.AsString() + "\""; 
        }
        protected string FormatAttribute<T>(string name, T value) where T : class
        {
            return this.FormatAttribute(name, value, null);
        }
        protected string FormatAttribute(string name, bool value)
        {
            return this.FormatAttribute(name, value, false);
        }
        public override string Format(int indent)
        {
            string indentation = indent > 0 ? new string('\t', indent) : "";
            string result;
            result = indentation + "<" + this.TagName + this.FormatAttributes() + ">" + (this.NoLineBreaks || indent < 0 ? "" : "\n");
            if (!this.Empty)
                result = result + this.Fold((node, accumulator) => accumulator + node.Format(this.NoLineBreaks || indent < 0 ? -1 : indent + 1), "") +
                    (this.NoLineBreaks ? "" : indentation) + "</" + this.TagName + ">" + (indent < 0 ? "" : "\n");
            return result;
        }
        System.Collections.Generic.IEnumerator<Node> System.Collections.Generic.IEnumerable<Node>.GetEnumerator()
        {
            return this.childNodes.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.childNodes.GetEnumerator();
        }
    }
}
