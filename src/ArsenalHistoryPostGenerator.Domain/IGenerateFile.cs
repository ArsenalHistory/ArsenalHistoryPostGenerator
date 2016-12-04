using System.Collections.Generic;

namespace ArsenalHistoryPostGenerator.Domain
{
    public interface IGenerateFile
    {
        bool GenerateMarkdownFile(string fileName, Dictionary<string, string> frontMatterDictionary);
    }
}