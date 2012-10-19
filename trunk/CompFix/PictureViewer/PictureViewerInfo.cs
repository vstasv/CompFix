using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CompFix.PictureViewer
{
    public class PictureViewerInfo
    {
        public PictureViewerInfo()
        {
            DisplayWidth = 300;
            ColumnCount = 3;
        }

        public int DisplayWidth;
        public int ColumnCount;
        public string FolderName;
    }

    public class PictureViewerHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            object width=context.Request.Params["width"];
            int widthPics = 300;
            if (null!=width)
            {
                int.TryParse(width.ToString(), out widthPics);
            }
            context.Response.Write("<html><head><title>Обработчик картинок</title></head><body>");
            DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"\Pics");
            FileInfo[] files = directoryInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                context.Response.Write(string.Format(@"<img src='Pics\{0}' width='{1}'/>",files[i].Name,widthPics));
            }
            context.Response.Write("</body></html>");
        }
    }

}