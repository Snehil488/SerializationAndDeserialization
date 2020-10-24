using System;

namespace SerializationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySerialization serialization = new BinarySerialization();
            //serialization.Serialization();
            //serialization.Deserialization();
            JSONSerialization jSONSerialization = new JSONSerialization();
            //jSONSerialization.Serialization();
            jSONSerialization.Deserialization();
        }
    }
}
