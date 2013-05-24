using System;

namespace Html.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Html.Document document = new Html.Document();

            //Html.Title title = new Html.Title();
            //title.Add(new Html.Text("Page Title"));
            //document.Head.Add(title);


            document.Head.Add(new Html.Title("Page Title"));
            document.Body.Add(new Html.Header1("header 1."));
            document.Body.Add(new Html.Paragraph("Paragraph 1."));
            document.Body.Add(new Html.Paragraph("Paragraph 2."));
            document.Body.BgColor = "pink";
            Html.Paragraph paragraph = new Html.Paragraph();
//            paragraph.Add(new Html.Text("Here is a "), new Html.Anchor("link") { Destination = "http://imint.se" }, new Html.Text("."));
            paragraph.Add(new Html.Text("Here is a "));
            paragraph.Add(new Html.Anchor("link") {Id = "here",Style = "color: red", Destination = "http://imint.se" });
            paragraph.Add(new Html.Text("."));
            document.Body.Add(paragraph);
            document.Body.Add(new Html.Button("hey click here") { Onclick = "alert('oye oye oye')" });
            //document.Body.Add(new Html.Table.Add(new Html.TableRow.Add(new Html.TableColumn("january"), new Html.TableColumn("100"))));
            Html.Table table = new Table() { Bgcolor = "yellow", Border = "5" };
            Html.TableRow tablerow = new TableRow();
            tablerow.Add(new Html.TableColumn("january"));
            tablerow.Add(new Html.TableColumn("100"));
            table.Add(tablerow);
            document.Body.Add(table);
            string data = document.ToString();

            document.Save("test.html");

            System.Diagnostics.Process.Start("test.html");

        }
    }
}
