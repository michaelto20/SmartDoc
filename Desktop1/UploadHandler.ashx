<%@ WebHandler Language="C#" Class="UploadHandler" %>

using System;
using System.Web;
using System.IO;
using DocxParser;

public class UploadHandler : IHttpHandler {

    public void ProcessRequest (HttpContext context)
    {
        string path = context.Request["path"];

        FileInfo fn = new FileInfo(path);
        File.Delete(context.Server.MapPath("~/Upload/" + fn.Name));
        fn.CopyTo(context.Server.MapPath("~/Upload/" + fn.Name));
        //Parser parser = new Parser(fn.Name);

        string fields = ValidateSmartDoc.ParseSmartDoc(fn.Name);
        context.Response.Write(fields);

        //context.Response.Write(fn.Name + ":" + fn.Length + ":" + fn.Extension + ":" + fn.FullName);
    }

    public bool IsReusable{
        get {
            return false;
        }
    }
}
