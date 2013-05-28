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
            return indent < 0 ? this.Value : new string(' ', indent) + this.Value + "\n";
        }
    }
}
