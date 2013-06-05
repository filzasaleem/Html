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
            Html.Body body = new Body() { Style = "color : purple" };

            document.Body.Style = "background: LightGrey";
            document.Body.Add(new Html.LineBreak());
            document.Head.Add(new Html.Title("Page Title"));
            document.Body.Add(new Html.Heading1("heading 1."));
            document.Body.Add(new Html.Paragraph("Paragraph 1.") { SpellCheck = true, ContentEditable = true });
            document.Body.Add(new Html.Paragraph("Paragraph 2."));
            Html.Paragraph paragraph = new Html.Paragraph();
            paragraph.Add(new Html.Text("Here is a "));
            paragraph.Add(new Html.Anchor("link") {Identifier = "here", Style = "color: red", Destination = "http://imint.se" });
            paragraph.Add(new Html.Text("."));
            document.Body.Add(paragraph);
            document.Body.Add(new Html.Button("hey click here") { OnClick = "alert('oye oye oye')" });
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.Table(new Html.ColumnGroup(new Html.Column(){Span = "5"}),new Html.TableRow(new Html.TableData("january"), new Html.TableData("100"))) { Border = "3" });
            //Html.Table table = new Table() { Border = "5" };
            //Html.TableRow tablerow = new TableRow();
            //tablerow.Add(new Html.TableData("january"));
            //tablerow.Add(new Html.TableData("100"));
            //table.Add(tablerow);
            //document.Body.Add(table);
            document.Body.Add(new Html.LineBreak());
            document.Body.Add(new Html.Figure(new Html.Image() { Source = "smileys_Laugh.jpg", Height = "100", Width = "100", Alternate = "smiley" },new Html.FigureCaption("Fig-1: Smiley")));
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
            document.Body.Add(new Html.Audio(new Html.MediaSource() { Source = "sample.ogg", Type = "audio/ogg" }, new Html.MediaSource() { Source = "sample.mp3", Type = "audio/mpeg" }, "No supported format available.") { Controls = true });
            document.Body.Add(new Html.Emphasized("Emphasized text"),new Html.LineBreak());
            document.Body.Add(new Html.Strong("Strong text"),new Html.LineBreak());
            document.Body.Add(new Html.Definition("Definition term"), new Html.LineBreak());
            document.Body.Add(new Html.Code("a piece of computer code"), new Html.LineBreak());
            document.Body.Add(new Html.KeyBoardInput ("keyboardinput sample"), new Html.LineBreak());
            document.Body.Add(new Html.Sample("sample output from computer code"), new Html.LineBreak());
            document.Body.Add(new Html.Variable("variable"), new Html.LineBreak());
            document.Body.Add(new Html.DescriptionList(new Html.DefineTerm("Coffee"), new Html.DescriptionData("black hot drink"), new Html.DefineTerm("Milk"), new Html.DescriptionData("white cold drink")));
            document.Body.Add(new Html.Paragraph("my favorite color is ", new Html.Deleted("red") { DateTime = "2012/6/30" }, new Html.Insert("blue")));
            document.Body.Add(new Html.Division(new Html.Paragraph("this is paragraph"), new Html.Heading3("this is heading")) { Style = "color : purple" });
            document.Body.Add(new Html.Italic("this text is in italic"));
            document.Body.Add(new Html.HorizontalRule());
            document.Body.Add(new Html.InlineFrame(new Html.Paragraph("Inline Frame")) { Source = "http://www.w3schools.com" });
            document.Body.Add(new Html.Form(new Html.FieldSet(new Html.Legend("Form"), new Html.Label("Firse Name :") { For = "fname" }, new Html.Input() { Type = "text", Identifier  = "fname"}, new Html.LineBreak(), "Last Name: ", new Html.Input() { Type = "text", Name = "lname" }, new Html.LineBreak(), "Encryption: ", new Html.KeyGenerator() { Name = "security" }, new Html.LineBreak(), new Html.Input() { Type = "submit", Value = "submit" })));
            document.Body.Add(new Html.Paragraph("do not forget to buy " , new Html.Mark("milk"), " today"));
            document.Body.Add(new Html.Meter("2 out of 10") { CurrentValue = "2", Minimum = "0", Maximum = "10" });
            document.Body.Add(new Html.NoScript("this is no script text"));
            document.Body.Add(new Html.OredredList(new Html.ListItem("coffee"), new Html.ListItem("Tea"), new Html.ListItem("milk")) { StartValue = "50", Reversed = true  });
            document.Body.Add(new Html.Select(new Html.OptionGroup(new Html.Option("Volvo"), new Html.Option("saab")) { LabelForOption = "Swedish Cars" }));
            document.Body.Add(new Html.PreformattedText("this is the     preformated text"));
           ///look for the end tag...
            document.Body.Add(new Html.Progress() { Value = "32", Maximum = "150" });
            //document.Body.Add(new Html.LineBreak());
            //look for the new line here.
            document.Body.Add(new Html.Paragraph(new Html.Small("this is small text")));

            document.Body.Add(new Html.Paragraph("this text has ", new Html.SubScript("subscript"), "and aslo", new Html.SuperScript("superscript")));
            document.Body.Add(new Html.TextArea("hello this is text area") { Row = "2", Column = "10" });
            document.Body.Add(new Html.Paragraph("this is ", new Html.UnderLine("paragraph")));
            //document.Body.Add(new Html.Embedded() { Source = "hej.png" });
           

            string data = document.ToString();
           
            
            document.Save("test.html");

            System.Diagnostics.Process.Start("test.html");

        }
    }
}
