using System.IO;
using System.Text;
using System.Xml;
using static System.Console;

namespace Certificacao70483.ManipulationString
{
    class Program
    {
        static void Main()
        {
            var myString = new StringBuilder(string.Empty);
            var stringWrite = new StringWriter();
            for (int i = 0; i < 1000; i++)
            {
                myString.Append($"Numero : {i} \n");
            }
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWrite))
            {
                xmlWriter.WriteStartElement("book","livro");
                xmlWriter.WriteElementString("preço","19.99");
                xmlWriter.WriteEndElement();
                xmlWriter.Flush();
            }
            WriteLine(myString);
            string xml = stringWrite.ToString();

            WriteLine(xml);
            ReadLine();

        }
    }
}
