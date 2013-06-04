using System;

namespace Html
{
    public class Track :
        Element
    {
        protected override string TagName { get { return "track"; } }
        public string Source { get; set; }
        public string Kind { get; set; }
        public string TitleOfTrack { get; set; }
        public string SourceLanguage { get; set; }
        public string Default { get; set; }
        protected override string FormatAttributes()
        {
            return 
                this.FormatAttribute("src", this.Source)+
                this.FormatAttribute("kind", this.Kind)+
                this.FormatAttribute("label", this.TitleOfTrack) +
                this.FormatAttribute("srclang", this.SourceLanguage)+
                this.FormatAttribute("default", this.Default);
        }
    }
}
