using System;

namespace Html
{
    public class Audio :
        Element
    {
        protected override string TagName { get { return "audio"; } }
        #region Constructors
        public Audio()
        {
            this.NoLineBreaks = true;
        }
        public Audio(Node content) :
            this()
        {
            this.Add(content);
        }
        public Audio(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        public string AutoPlay { get; set; }
        public string Control { get; set; }
        public string Loop { get; set; }
        public string Muted { get; set; }
        public string PreLoad { get; set; }
        public string Source { get; set; }
        protected override string FormatAttributes()
        {
            return
                 this.FormatAttribute("autoplay", this.AutoPlay) +
                 this.FormatAttribute("control", this.Control) +
                 this.FormatAttribute("loop", this.Loop) +
                 this.FormatAttribute("muted", this.Muted) +
                 this.FormatAttribute("preload", this.PreLoad) +
                 this.FormatAttribute("src", this.Source);
        }
    }
}
