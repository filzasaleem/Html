using System;

//The <meter> tag defines a scalar measurement within a known range, or a fractional value. This is also known as a gauge.

namespace Html
{
    public class Meter :
        Element
    {
        protected override string TagName { get { return "meter"; } }
        public string CurrentValue { get; set; }
        public string Minimum { get; set; }
        public string Maximum { get; set; }
        public string FormIdentifier { get; set; }
        public string HighValue { get; set; }
        public string LowValue { get; set; }
        public string OptimumValue { get; set; }
        #region Constructor
        public Meter()
        {
            this.NoLineBreaks = true;
        }
        public Meter(Node content) :
            this()
        {
            this.Add(content);
        }
        public Meter(params Node[] nodes) :
            this()
        {
            this.Add(nodes);
        }
        #endregion
        protected override string FormatAttributes()
        {
            return
                base.FormatAttributes() +
                this.FormatAttribute("form", this.FormIdentifier)+
                this.FormatAttribute("value", this.CurrentValue)+
                this.FormatAttribute("min", this.Minimum)+
                this.FormatAttribute("max", this.Maximum)+
                this.FormatAttribute("high", this.HighValue)+
                this.FormatAttribute("low", this.LowValue)+
                this.FormatAttribute("optimum", this.OptimumValue);
        }
    }
}
