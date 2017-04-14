﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;


using DocumentFormat;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;


namespace DocxParser
{
    public class Parser
    {
        public string Filename { get; set; }
        public XmlDocument doc = new XmlDocument();

        public Parser(string filename)
        {
            this.Filename = filename;
            try
            {
                using (StreamReader tx = new StreamReader(filename))
                {
                    doc.Load(tx);
                }
    
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
            
        }

        

        public string GetXML(string xdoc = null)
        {
            //if (xdoc == null)
            //{
            //    doc.Load(HttpContext.Current.Server.MapPath("~/XMLTemplates/People_Person.xml"));
            //}
            //else
            //{
            //    doc.LoadXml(xdoc);
            //}

            string text = doc.DocumentElement.Name;
            foreach (XmlNode root in doc.DocumentElement.ChildNodes)
            {
                text = text + ", " + root.Name.Trim();

                foreach (XmlNode node in root.ChildNodes)
                {
                    text = text + ", " + node.Name.Trim();

                }
            }
            return text;

        }

        public List<FieldValues> GetValues(string xdoc)
        {
            List<FieldValues> fieldValues = new List<FieldValues>();
            doc.LoadXml(xdoc);

            foreach (XmlNode root in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    string fieldName = node.Name.Trim();
                    string value = node.InnerText;
                    FieldValues fieldValue = new FieldValues(fieldName, value);
                    fieldValues.Add(fieldValue);
                }
            }


            return fieldValues;

        }

        public List<FieldAttributes> GetFields()
        {
            doc.Load(HttpContext.Current.Server.MapPath("~/XMLTemplates/People_Person.xml"));
            List<FieldAttributes> fields = new List<FieldAttributes>();

            foreach (XmlNode root in doc.DocumentElement.ChildNodes)
            {
                
                foreach (XmlNode node in root.ChildNodes)
                {
                    bool isRequired;
                    string dataType = node.Attributes["Datatype"]?.InnerText;
                    string Required = node.Attributes["Required"]?.InnerText;
                    isRequired = Required.Equals("true");
                    string fieldName = node.Name.Trim();
                    FieldAttributes field = new FieldAttributes(fieldName,dataType, isRequired);
                    fields.Add(field);
                }
            }
            return fields;

        }

      

      
        private XDocument GetCustomXmlPartAsXDocument(MainDocumentPart mainDocumentPart, string aznamespace = "")
        {
            if (mainDocumentPart == null)
            {
                throw new ArgumentNullException("mainDocumentPart");
            }

            XDocument result = null;

            foreach (CustomXmlPart part in mainDocumentPart.CustomXmlParts)
            {
                using (XmlTextReader reader = new XmlTextReader(part.GetStream(FileMode.Open, FileAccess.Read)))
                {
                    reader.MoveToContent();

                    var s = reader.ReadOuterXml();
                    result = XDocument.Parse(s);
                    break;
                }
            }

            return result;
        }


        public XDocument ReadCustomXmlDoc()
        {
            XDocument xdoc = new XDocument();

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(this.Filename, false))
            {
                MainDocumentPart mainPart = wordDoc.MainDocumentPart;
                // Just get the first one with the namespace of interest.
                xdoc = GetCustomXmlPartAsXDocument(mainPart);
            }

            return xdoc;
        }

        public string GetTemplateName()
        {
            //var xdoc = XDocument.Load(@newFile);

            string templateName = "";
            //var xdoc = XDocument.Parse(doc.OuterXml);

            XmlNodeList elemList = doc.GetElementsByTagName(doc.FirstChild.Name);
            for (int i = 0; i < elemList.Count; i++)
            {
                string attrVal = elemList[i].Attributes["SDTemplate"].Value;
            }

            //var items = from i in xdoc.Descendants("Item")
            //            select new
            //            {
            //                SDTemplate = (string)i.Attribute("SDTemplate"),
            //            };

            //foreach (var s in items)
            //{
            //    templateName += s;
            //}


            return templateName;
        }



    }
}