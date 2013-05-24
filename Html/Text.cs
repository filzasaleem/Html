using System;

namespace Html
{
    public class Text :
        Node
    {
        public string Value { get; set; }
        public Text(string value)
        {
            this.Value = value;
        }
        public Text()
        {
        }
        public override string Format(int indent)
        {
            return new string('\t', indent) + this.Value + "\n";
        }
    }
}
