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

            document.Body.Add(new Html.LineBreak());
            document.Head.Add(new Html.Title("Page Title"));
            document.Body.Add(new Html.Header1("header 1."));
            document.Body.Add(new Html.Paragraph("Paragraph 1.") { SpellCheck = true, ContentEditable = true });
            document.Body.Add(new Html.Paragraph("Paragraph 2."));
            Html.Paragraph paragraph = new Html.Paragraph();
//            paragraph.Add(new Html.Text("Here is a "), new Html.Anchor("link") { Destination = "http://imint.se" }, new Html.Text("."));
            paragraph.Add(new Html.Text("Here is a "));
            paragraph.Add(new Html.Anchor("link") {Identifier = "here", Style = "color: red", Destination = "http://imint.se" });
            paragraph.Add(new Html.Text("."));
            document.Body.Add(paragraph);
            document.Body.Add(new Html.Button("hey click here") { Onclick = "alert('oye oye oye')" });
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.LineBreak());
            //document.Body.Add(new Html.Table.Add(new Html.TableRow.Add(new Html.TableColumn("january"), new Html.TableColumn("100"))));
            Html.Table table = new Table() { Border = "5" };
            Html.TableRow tablerow = new TableRow();
            tablerow.Add(new Html.TableData("january"));
            tablerow.Add(new Html.TableData("100"));
            table.Add(tablerow);
            document.Body.Add(table);
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.Image() { Source = "smileys_Laugh.jpg", Height = "100", Width = "100", Alternate = "smiley" });
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.Paragraph("Here is a quote from WWF's website."));
            document.Body.Add(new Html.BlockQuote("For 50 years, WWF has been protecting the future of nature. The world's leading conservation organization,  WWF works in 100 countries and is supported by 1.2 million members in the United States and close to 5 million globally. ") { ContentEditable = true });
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.Quote("Build a future where people live in harmony with nature."));
            document.Body.Add(new Html.LineBreak());
            Html.Paragraph para = new Paragraph("this is simple text and ");
            para.Add(new Html.Bold("this is bold text"));
            document.Body.Add(para);
            document.Body.Add(new Html.Paragraph("this is simple text and ", new Html.Bold("this is bold text")));
            document.Body.Add(new Html.Paragraph("the ", new Html.Abbreviation("WHO ") { Title = "world health organization " }, "was founded in 1948."));
            document.Body.Add(new Html.Address("IMINT image Intelligence AB ", new Html.LineBreak(), "Dag Hammarskjolds vag 10C ", new Html.LineBreak(), "751 83 Uppsala, Sweden "));
            document.Body.Add(new Html.Paragraph("Mig och min familij besökt The Epcot förra sommar"));
            document.Body.Add(new Html.Aside(new Html.Paragraph("The Epcot Center is a theme park in Disney World, Florida.")));
            document.Body.Add(new Html.Audio(new Html.Source() { Src = "sample.ogg", Type = "audio/ogg" }) { Control = "controls" });
            //document.Head.Add(new Html.Base(){Destination = "http://www.w3schools.com/images/", Target="_blank"});
            document.Body.Add(new Html.Emphasized("Emphasized text"),new Html.LineBreak());
            document.Body.Add(new Html.Strong("Strong text"),new Html.LineBreak());
            document.Body.Add(new Html.Definition("Definition term"), new Html.LineBreak());
            document.Body.Add(new Html.Code("a piece of computer code"), new Html.LineBreak());
            document.Body.Add(new Html.KeyBoardInput ("keyboardinput sample"), new Html.LineBreak());
            document.Body.Add(new Html.Sample("sample output from computer code"), new Html.LineBreak());
            document.Body.Add(new Html.Variable("variable"), new Html.LineBreak());
            string data = document.ToString();
           
            
            document.Save("test.html");

            System.Diagnostics.Process.Start("test.html");

        }
    }
}
