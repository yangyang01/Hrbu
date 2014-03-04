using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS.Eka.HTHR.WebUI.UserControls.Services
{
    public class HandlerBase
    {
        public HttpRequest Request
        {
            get
            {
                return HttpContext.Current.Request;
            }
        }

        public HttpResponse Response
        {
            get
            {
                return HttpContext.Current.Response;
            }
        }

        public string GetQueryString(string queryKey)
        {
            if (string.IsNullOrEmpty(Request.QueryString[queryKey]))
                return "";
            else
                return Request.QueryString[queryKey];
        }
    }
}