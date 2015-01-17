using System;

namespace JRAMelissaWrapper
{
    public class ParseResult : IParseResult
    {
        public String Code { get; set; }
        public String ShortDescription { get; set; }
        public String LongDescription { get; set; }
        public Boolean FatalAddressError { get; set; }
        public override string ToString()
        {
            return String.Format("Code: {0} | Message:{1} | Description: {2} | FatalAddressError: {3} ", Code, ShortDescription,
                LongDescription, FatalAddressError);
            ;
        }
    }
}
