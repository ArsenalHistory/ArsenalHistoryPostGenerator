using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ArsenalHistoryPostGenerator.Domain
{
    public class GenerateFile : IGenerateFile
    {
        private readonly string _directory;

        public GenerateFile(IConfiguration configuration)
        {
            _directory = configuration.GetSection("ArsenalHistoryPostsPath").Value;
            if (!Directory.Exists(configuration.GetSection("ArsenalHistoryPostsPath").Value)) { throw new System.IO.DirectoryNotFoundException($"Directory not found {_directory}"); }
            
        }

        public bool GenerateMarkdownFile(string fileName, Dictionary<string, string> frontMatterDictionary)
        {
            if (frontMatterDictionary == null || frontMatterDictionary.Count == 0)
            {
                throw new ArgumentNullException(nameof(frontMatterDictionary), "Parameter is null or empty");
            }

            string fileToCreate = "---\n";
            foreach (KeyValuePair<string, string> keyValuePair in frontMatterDictionary)
            {
                fileToCreate += $"{keyValuePair.Key}: {keyValuePair.Value}\n";
            }

            fileToCreate += "---";

            File.WriteAllText(_directory + fileName, fileToCreate);

            return false;
        }
    }
}
