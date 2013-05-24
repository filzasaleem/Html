using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Html
{
    public class TableColumn :
        Element
    {
        protected override string Name { get { return "td"; } }
         public TableColumn()
        {

        }
        public TableColumn(string content)
        {
            this.Add(new Text(content));
        }
    }
}
