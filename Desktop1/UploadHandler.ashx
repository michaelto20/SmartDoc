<%@ WebHandler Language="C#" Class="UploadHandler" %>

using System;
using System.Web;
using System.IO;

public class UploadHandler : IHttpHandler {

    public void ProcessRequest (HttpContext context)
    {
        string path = context.Request["path"];

        FileInfo fn = new FileInfo(path);
        fn.CopyTo(context.Server.MapPath("~/Upload/" + fn.Name));
        context.Response.Write(fn.Name + ":" + fn.Length + ":" + fn.Extension);
    }

    public bool IsReusable{
        get {
            return false;
        }
    }
}