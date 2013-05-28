using System;

namespace Html
{
    public class TableRow :
        Element 
    {
        protected override string TagName { get { return "tr"; } }
         public TableRow()
        {

        }
        public TableRow(string content)
        {
            this.Add(new Text(content));
        }
    }
}
