using System;
using System.Xml;

//Integrantes
//Greys Villa       6570
//Hector Urquizo    6571
namespace GrupalParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector("https://www.w3schools.com/xml/Books.xml");
        }

        private static void Lector(string contenido)
        {
            try
            {
                XmlDocument docXml = new XmlDocument();
                docXml.Load(contenido);
                int index = 0;
                foreach (XmlNode node in docXml.DocumentElement)
                {
                    index++;
                    Console.WriteLine(node.Name + " " + index);
                    foreach (XmlNode subNode in node.ChildNodes)
                    {
                        string objeto = subNode.Name + ": " + subNode.InnerText;
                        Console.WriteLine(objeto);
                    }
                    Console.WriteLine("");
                }
            }
            catch
            {
                Console.WriteLine("La direccion url no es válida");
            }
        }
    }
}
