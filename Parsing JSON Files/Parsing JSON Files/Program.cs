using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Include
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Parsing_JSON_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //string jsonText = File.ReadAllText("Student.json");
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //Student student = serializer.Deserialize<Student>(jsonText);
            //Console.WriteLine(student.Name + ":" + student.Age);
            //Console.ReadKey();

            //Josn.net
            string jsonText = File.ReadAllText("Student.json");
            Student student = JsonConvert.DeserializeObject<Student>(jsonText);
            Console.WriteLine(student.Name + ":" + student.Age);
            Console.ReadKey();
        }
    }
}
