using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace SerializationPractice
{
    class JSONSerialization
    {
        public void Serialization()
        {
            Demo demo = new Demo();
            demo.Id = 101;
            demo.Name = "Swastik Verma";
            string json = JsonConvert.SerializeObject(demo);
            Console.WriteLine(json);
            File.WriteAllText(@"C:\Users\Snehil\source\repos\SerializationPractice\jsonfile.json", json);
        }

        public void Deserialization()
        {
            string jason = File.ReadAllText(@"C:\Users\Snehil\source\repos\SerializationPractice\jsonfile.json");
            Demo demo = JsonConvert.DeserializeObject<Demo>(jason);
            Console.WriteLine(demo.Id + "\n" + demo.Name);
        }
    }
}
