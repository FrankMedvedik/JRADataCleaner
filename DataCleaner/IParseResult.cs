using System;

namespace DataClean
{
    public interface IParseResult
    {
        String Code { get; set; }
        String ShortDescription { get; set; }
        String LongDescription { get; set; }
        Boolean FatalAddressError { get; set; }
        string ToString();
    }
}