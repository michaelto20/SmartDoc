using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocxParser;


namespace DocxParserApp
{
    class Program
    {
        static void ParseSmartDoc(string smartDocFileName)
        {

            // Read a docx file and parse it.
            string doc1 = "";
            string doc2 = "";

            // Get Smart Doc fields
            var srcfname = @".\"+ smartDocFileName;
            var dstfname = @".\test.docx";
            File.Delete(dstfname);
            File.Copy(srcfname, dstfname);

            Parser parser = new Parser(dstfname);

            // Get fields from template
            doc1 = parser.GetXML();

            // Get SmartDoc values
            var xdoc = parser.ReadCustomXmlDoc();
            doc2 = parser.GetXML(xdoc.ToString());

            if (doc1.Equals(doc2))
            {

                List<DocxParser.FieldAttributes> fieldAttributes = parser.GetFields();
                List<DocxParser.FieldValues> fieldValues = parser.GetValues(xdoc.ToString());

                if (CompareXML(fieldValues, fieldAttributes))
                {
                    Console.WriteLine(Preview(fieldValues));
                }
            }
            // Done
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        public static bool CompareXML(List<DocxParser.FieldValues> fieldValues, List<DocxParser.FieldAttributes> fieldAttributes)
        {
            for (int i = 0; i < fieldValues.Count; i++)
            {
                    if (fieldValues[i].FieldName.Equals(fieldAttributes[i].FieldName))
                    {
                        if (fieldAttributes[i].IsRequired && String.IsNullOrWhiteSpace(fieldValues[i].FieldValue))
                        {
                            return false;
                        }
                        int num;
                        if (fieldAttributes[i].DataType.Equals("integer") && !int.TryParse(fieldValues[i].FieldValue, out num))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
            }

            return true;
        }

        public static string Preview(List<DocxParser.FieldValues> fieldValues)
        {
            string text = "";

            for(int i = 0; i < fieldValues.Count && i < 3; i++)
            {
                 text = text + fieldValues[i].FieldName + ": " + fieldValues[i].FieldValue + "\n";      
            }
            return text;
        }
    }
}
