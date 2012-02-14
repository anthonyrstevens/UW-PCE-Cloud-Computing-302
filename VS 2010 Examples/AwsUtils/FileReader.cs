using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AwsUtils
{
    public class FileReader
    {
        public virtual string Read(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        public virtual string Read(System.Reflection.Assembly assembly, string offsetPath)
        {
            var codeBase = assembly.CodeBase;
            var uriBuilder = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uriBuilder.Path);
            var directory = Path.GetDirectoryName(path);
            var filePath = Path.Combine(directory, offsetPath);
            return this.Read(filePath);
        }
    }
}
