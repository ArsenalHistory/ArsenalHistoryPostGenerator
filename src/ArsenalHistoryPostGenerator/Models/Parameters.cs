using System;
using System.Collections.Generic;

namespace ArsenalHistoryPostGenerator.Web.Models
{
    public class Parameters
    {
        public static readonly Dictionary<string, string> FrontMatterDictionary = new Dictionary<string, string>
        {
            {"layout", "post"},
            {"title", ""},
            {"date", ""},
            {"categories", ""},
            {"video", ""},
            {"summary", ""},
            {"permalink", ""},
        }; 
    }
}
