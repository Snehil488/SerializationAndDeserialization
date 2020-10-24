using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializationPractice
{
    class BinarySerialization
    {
        public void Serialization()
        {
            FileStream file = new FileStream(@"C:\Users\Snehil\source\repos\SerializationPractice\NewTextFile.txt", FileMode.Create);
            Demo demo = new Demo();
            demo.Id = 101;
            demo.Name = "Snehil Singh";
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(file, demo);
        }

        public void Deserialization()
        {
            FileStream file = new FileStream(@"C:\Users\Snehil\source\repos\SerializationPractice\NewTextFile.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo demo = (Demo)binaryFormatter.Deserialize(file);
            Console.WriteLine(demo.Id+"\n"+demo.Name);
        }
    }

    [Serializable]
    class Demo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
