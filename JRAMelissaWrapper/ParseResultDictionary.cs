using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Newtonsoft.Json;

namespace JRAMelissaWrapper
{
    public class ParseResultDictionary : Dictionary<string, ParseResult>
    {
        
        public String DictionaryFileName { get; set; }

        public ParseResultDictionary()
        {
            DictionaryFileName = "MelissaCodes.json";
            Initialize();
        }

        public ParseResultDictionary(string codeFileName)
        {
            DictionaryFileName = codeFileName;
            Initialize();
        }

        public ParseResult[] GetAllMessages()
        {
            return (from a in this where a.Value.FatalAddressError select a.Value).OrderBy(x => x.Code).ToArray();
        }

        public ParseResult[] GetAllFatalErrors()
        {
            return (from a in this where a.Value.FatalAddressError select a.Value).OrderBy(x => x.Code).ToArray();
        }
        private static readonly ILog Logger =
            LogManager.GetLogger(typeof(ParseResultDictionary));


        private void Initialize()
        {
            try
            {
                string json = File.ReadAllText(DictionaryFileName);
                var parseResultList = JsonConvert.DeserializeObject<List<ParseResult>>(json);
                foreach (var p in parseResultList)
                {
                    Add(p.Code, p);
                }
            }
            catch (Exception e)
            {

                Logger.Error(e.ToString());
                throw;
            }
        }

        private IParseResult LookupCode(string resultcode)
        {
            ParseResult msg;
            if (!TryGetValue(resultcode, out msg))
                msg = new ParseResult()
                {
                    Code = resultcode,
                    FatalAddressError = true,
                    ShortDescription = "Undefined",
                    LongDescription = String.Format("Code is not defined in {0}", DictionaryFileName)
                };
            return msg;
        }

        public IParseResult[] LookupCodeList(IEnumerable<string> results)
        {
            return results.Select(LookupCode).ToArray();
        }
    }
}
