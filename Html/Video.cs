using System;

namespace Html
{
    public class Video :
        Element
    {
        protected override string TagName { get { return "video"; } }
        public string Source { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string AutoPlay { get; set; }
        public string Control { get; set; }
        public string Loop { get; set; }
        public string Muted { get; set; }
        public string Poster { get; set; }
        public string PreLoad { get; set; }
        #region Constructor
        public Video()
        {
            this.NoLineBreaks = true;
        }
        public Video(Node content) :
            this()
        {
            this.Add(content);
        }
        public Video(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                this.FormatAttribute("src", this.Source) +
                this.FormatAttribute("width", this.Width) +
                this.FormatAttribute("height", this.Height) +
                this.FormatAttribute("controls", this.Control) +
                this.FormatAttribute("loop", this.Loop)+
                this.FormatAttribute("muted", this.Muted) +
                this.FormatAttribute("poster", this.Poster) +
                this.FormatAttribute("preload", this.PreLoad);
        }
    }
}
