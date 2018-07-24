using System;
using System.IO;
namespace ExposureTest.Resources.Client
{
    public class StubDataLoader
    {
    
        public static string LoadTestFile(string filename)
        {
            var dir = Path.Combine( $"TestData/{filename}");
            Console.WriteLine(dir);
            return File.ReadAllText(dir);
        }   
    }
}