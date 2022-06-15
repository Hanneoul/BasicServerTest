using System;
using System.IO;
using System.Text.Json;

namespace Lecture15
{
    class FileLogger
    {
        public string _fileName { get; set; }

        public FileLogger(string fileName)
        {
            _fileName = fileName;
        }

        public void Write(string logMessage)
        {
            StreamWriter writer;
            writer = File.CreateText(_fileName);        //Text File이 저장될 위치(파일명)
                                                        //파일 이름만 지정하면 컴파일된 폴더내 해당 파일 이름으로 저장됨
            writer.WriteLine(logMessage);               //저장될 string
            writer.Close();
        }

        //public void Store(Settings settings, string fileName)
        //{
        //    // Serialize
        //    string jsonString = JsonSerializer.Serialize(settings);
        //    System.Console.WriteLine(jsonString);
        //    StreamWriter writer;
        //    writer = File.CreateText(fileName);        //Text File이 저장될 위치(파일명)
        //                                               //파일 이름만 지정하면 컴파일된 폴더내 해당 파일 이름으로 저장됨
        //    writer.WriteLine(jsonString);    //저장될 string
        //    writer.Close();
        //}
        //public static Settings Load(string fileName)
        //{
        //    string jsonString = File.ReadAllText(fileName);
        //    return JsonSerializer.Deserialize<Settings>(jsonString);
        //}
    }
}
