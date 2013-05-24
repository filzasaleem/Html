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
            //document.Body.Attribute.Add("red");
           // document.Attribute("bgcolor", "red");
            Html.Paragraph paragraph = new Html.Paragraph();
//            paragraph.Add(new Html.Text("Here is a "), new Html.Anchor("link") { Destination = "http://imint.se" }, new Html.Text("."));
            paragraph.Add(new Html.Text("Here is a "));
            paragraph.Add(new Html.Anchor("link") { Destination = "http://imint.se" });
            paragraph.Add(new Html.Text("."));
            document.Body.Add(paragraph);


            //document.Body.Attribute("bgcolor", "'brown'");
            string data = document.ToString();

            document.Save("test.html");

            System.Diagnostics.Process.Start("test.html");

        }
    }
}
