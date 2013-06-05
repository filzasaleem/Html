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
        public bool AutoPlay { get; set; }
        public bool Controls { get; set; }
        public bool Loop { get; set; }
        public bool Muted { get; set; }
        public string PreLoad { get; set; }
        public string Source { get; set; }
        protected override string FormatAttributes()
        {
            return
                 base.FormatAttributes() +
                 this.FormatAttribute("autoplay", this.AutoPlay) +
                 this.FormatAttribute("controls", this.Controls) +
                 this.FormatAttribute("loop", this.Loop) +
                 this.FormatAttribute("muted", this.Muted) +
                 this.FormatAttribute("preload", this.PreLoad) +
                 this.FormatAttribute("src", this.Source);
        }
    }
}
