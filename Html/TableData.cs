using System;

using System.Threading.Tasks;

namespace Html
{
    public class TableData :
        Element
    {
        protected override string TagName { get { return "td"; } }
        public TableData()
        {
            this.NoLineBreaks = true;
        }
        public TableData(string content) :
            this()
        {
            this.Add(new Text(content));
        }
    }
}
