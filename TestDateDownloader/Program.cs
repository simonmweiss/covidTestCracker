using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CovidTestObjects;

namespace TestDateDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDateDownloader downloader = new TestDateDownloader();
            var download = downloader.GetTestDates();
            foreach (KeyValuePair<string, List<TestDate>> downloaderDate in download.Result)
            {
                using FileStream createStream = File.Create(@"C:\Users\Simon\Desktop\TestDates\"+downloaderDate.Key+".json"); 
                var serialize = JsonSerializer.SerializeAsync(createStream, downloaderDate.Value);
                serialize.Wait();
            }
        }
    }
}
