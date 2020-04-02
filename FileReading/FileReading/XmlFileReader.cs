using System;
using System.Xml;

namespace FileReading
{
    public class XmlFileReader
    {
        public void ReadXMLFile(string file)
        {
           XmlReader reader = XmlReader.Create(file);

           while (reader.Read())
           {
               if (reader.IsStartElement())
               {
                   switch (reader.Name.ToString())
                       {
                           case "name":
                               Console.WriteLine(reader.ReadString());
                               break;
                           case "price":
                               Console.WriteLine(reader.ReadString());
                               break;
                           case "description":
                               Console.WriteLine(reader.ReadString());
                               break;
                           case "calories":
                               Console.WriteLine(reader.ReadString());
                               break;
                       }
               }
           }

           Console.ReadKey();
        }
    }
}