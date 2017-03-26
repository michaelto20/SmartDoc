using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;


// From: http://blogs.msdn.com/b/ericwhite/archive/2008/10/19/creating-data-bound-content-controls-using-the-open-xml-sdk-and-linq-to-xml.aspx
// See: http://dbe.codeplex.com/

// https://msdn.microsoft.com/en-us/library/bb398244.aspx
// http://blogs.msdn.com/b/brian_jones/archive/2009/01/05/taking-advantage-of-bound-content-controls.aspx


public static class LocalExtensions
{
    public static string StringConcatenate<T>(this IEnumerable<T> source,
            Func<T, string> func)
    {
        StringBuilder sb = new StringBuilder();
        foreach (T item in source)
            sb.Append(func(item));
        return sb.ToString();
    }

    public static string StringConcatenate(this IEnumerable<string> source)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string item in source)
            sb.Append(item);
        return sb.ToString();
    }

    public static XDocument GetXDocument(this OpenXmlPart part)
    {
        XDocument xdoc = part.Annotation<XDocument>();
        if (xdoc != null)
            return xdoc;
        using (Stream str = part.GetStream())
        using (StreamReader streamReader = new StreamReader(str))
        using (XmlReader xr = XmlReader.Create(streamReader))
            xdoc = XDocument.Load(xr);
        part.AddAnnotation(xdoc);
        return xdoc;
    }
}


class Program
{
    private static XNamespace w = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";
    private static XName r = w + "r";
    private static XName ins = w + "ins";
    private static XNamespace ds = "http://schemas.openxmlformats.org/officeDocument/2006/customXml";

    static string GetTextFromContentControl(XElement contentControlNode)
    {
        return contentControlNode.Descendants(w + "p")
            .Select(
                p => p.Elements()
                      .Where(z => z.Name == r || z.Name == ins)
                      .Descendants(w + "t")
                      .StringConcatenate(element =>
                          (string)element) + Environment.NewLine
            ).StringConcatenate();
    }

    static void Main(string[] args)
    {
        File.Delete("Test.docx");
        File.Copy("Template2.docx", "Test.docx");

        // Open the Open XML doc as a word processing doc
        using (WordprocessingDocument document = WordprocessingDocument.Open("Test.docx", true))
        {
            // Create the contents of the custom XML part
            XElement customXml = new XElement("Root",
                document
                .MainDocumentPart
                .GetXDocument()
                .Descendants(w + "sdt")
                .Select(sdt =>
                    new XElement(
                        sdt.Element(w + "sdtPr")
                            .Element(w + "tag")
                            .Attribute(w + "val").Value,
                        GetTextFromContentControl(sdt).Trim())
                )
            );

            // Create a new custom XML part
            CustomXmlPart customXmlPart = document.MainDocumentPart.AddCustomXmlPart(CustomXmlPartType.CustomXml);
            using (Stream str = customXmlPart.GetStream( FileMode.Create, FileAccess.ReadWrite))
            using (XmlWriter xw = XmlWriter.Create(str))
                customXml.Save(xw);

            Guid idGuid = Guid.NewGuid();

            // Create the contents of the properties part
            XDocument propertyPartXDoc = new XDocument(
                new XElement(ds + "datastoreItem",
                    new XAttribute(ds + "itemID",
                        "{" + idGuid.ToString().ToUpper() + "}"),
                    new XAttribute(XNamespace.Xmlns + "ds",
                        ds.NamespaceName),
                    new XElement(ds + "schemaRefs")
                )
            );

            // Add the custom XML properties part
            CustomXmlPropertiesPart customXmlPropertyPart = customXmlPart.AddNewPart<CustomXmlPropertiesPart>();
            using (Stream str = customXmlPropertyPart.GetStream( FileMode.Create, FileAccess.ReadWrite))
            using (XmlWriter xw = XmlWriter.Create(str))
                propertyPartXDoc.Save(xw);

            // Load the main document part into an XDocument
            XDocument mainDocumentXDoc;
            using (Stream str = document.MainDocumentPart.GetStream())
            using (XmlReader xr = XmlReader.Create(str))
                mainDocumentXDoc = XDocument.Load(xr);

            // Add the data binding elements to the main document
            foreach (XElement sdt in mainDocumentXDoc.Descendants(w + "sdt"))
                sdt.Element(w + "sdtPr")
                    .Element(w + "placeholder")
                    .AddAfterSelf(
                        new XElement(w + "dataBinding",
                            new XAttribute(w + "xpath",
                                "/Root/" + sdt.Element(w + "sdtPr")
                                    .Element(w + "tag")
                                    .Attribute(w + "val").Value),
                            new XAttribute(w + "storeItemID",
                                "{" + idGuid.ToString().ToUpper() + "}")
                        )
                    );

            // Serialize the XDocument back into the part
            using (Stream str = document.MainDocumentPart.GetStream( FileMode.Create, FileAccess.Write))
            using (XmlWriter xw = XmlWriter.Create(str))
                mainDocumentXDoc.Save(xw);
        }
    }
}
