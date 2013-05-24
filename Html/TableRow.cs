using System;


namespace Html
{
    public class TableRow :
        Element 
    {
        protected override string Name { get { return "tr"; } }
         public TableRow()
        {

        }
        public TableRow(string content)
        {
            this.Add(new Text(content));
        }
    }
}
