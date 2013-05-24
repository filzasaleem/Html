using System;
using Collection = Kean.Core.Collection;

namespace Html
{
    public abstract class Node
    {
        public abstract string Format(int indent);
        public override string ToString()
        {
            return this.Format(0);
        }
    }
}
