using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DocxParser
{
    public class ValidateSmartDoc
    {
        public static string ParseSmartDoc(string smartDocFileName)
        {

            // Read a docx file and parse it.
            string doc1 = "";
            string doc2 = "";

            // Get Smart Doc path from uploads folder
            var sdfname = HttpContext.Current.Server.MapPath("~/Upload/") + smartDocFileName;

            // Get SmartDoc values
            Parser sdParser = new Parser(sdfname);
            XDocument xdoc = sdParser.ReadCustomXmlDoc();
            doc2 = sdParser.GetXML(xdoc.ToString());

            // Get Smart Doc Template Name
            sdParser.GetTemplateName(xdoc);

            // Get fields from template
            doc1 = sdParser.GetXML();

            

            if (doc1.Equals(doc2))
            {

                List<DocxParser.FieldAttributes> fieldAttributes = sdParser.GetFields();
                List<DocxParser.FieldValues> fieldValues = sdParser.GetValues(xdoc.ToString());

                if (CompareXML(fieldValues, fieldAttributes))
                {
                    return Preview(fieldValues);
                }
            }
            return "Could not validate your document.";
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
                        if (fieldAttributes[i].DataType.Equals("Integer") && !int.TryParse(fieldValues[i].FieldValue, out num))
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
