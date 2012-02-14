using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AwsUtils;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AwsUtilsTests.TestCases
{
    [TestFixture]
    public class FileReaderTests
    {
        [Test]
        public void Read_reads_correct_contents()
        {
            // arrange
            var expected = "foobar foobar foobar";
            var path = GetResourcePath("foobar.txt");
            var reader = new FileReader();

            // act
            var actual = reader.Read(path);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        private string GetResourcePath(string fileName)
        {
            var currentAssemblyLocation = Assembly.GetExecutingAssembly().CodeBase;
            currentAssemblyLocation = ConvertToDrivePath(currentAssemblyLocation);
            var directory = System.IO.Directory.GetParent(currentAssemblyLocation).FullName;
            var resourcePath = String.Format(@"Resources\{0}", fileName);
            var path = Path.Combine(directory, resourcePath);
            return path;
        }

        private string ConvertToDrivePath(string path)
        {
            var temp = path;
            temp = temp.Replace("file://", "");
            temp = temp.TrimStart(new char[2] {'\\', '/'});
            temp = temp.Replace("/", @"\");
            return temp;
        }
    }
}
