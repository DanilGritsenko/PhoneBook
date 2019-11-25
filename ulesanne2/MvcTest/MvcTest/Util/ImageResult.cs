using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Util
{
    public class ImageResult : ActionResult
    {
        private string path;
        private string name;
        public ImageResult(string path, string name)
        {
            this.path = path;
            this.name = name;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Write("<div style='width:100%;text-align:center;'>" + "<p>Название книги: " + name +
                "</p> <img style='max-width:600px;' src='" + path + "' /></div>");
        }
    }
}