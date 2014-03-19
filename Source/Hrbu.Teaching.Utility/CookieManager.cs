using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Hrbu.Teaching.Utility
{
    public class CookieManager : AbstractSingleton<CookieManager>
    {
        public DateTime CookieExpireTime
        {
            get
            {
                return DateTime.Now.AddMonths(1);
            }
        }

        public HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }

        public HttpResponse Response
        {
            get
            {
                return Context.Response;
            }
        }

        public HttpRequest Request
        {
            get
            {
                return Context.Request;
            }
        }

        public void SetCookie(string name, string value)
        {
            var cookie = new HttpCookie(name, value);

            Response.Cookies.Set(cookie);
        }

        public string ReadCookie(string name)
        {
            if (Response.Cookies.AllKeys.Contains(name))
            {
                return Response.Cookies[name].Value;
            }

            if (Request.Cookies.AllKeys.Contains(name))
            {
                return Request.Cookies[name].Value;
            }

            return null;
        }

        public void ClearCookie(string name)
        {
            if (Response.Cookies.AllKeys.Contains(name))
            {
                Response.Cookies.Remove(name);
            }

            if (Request.Cookies.AllKeys.Contains(name))
            {
                Request.Cookies.Remove(name);
                Response.Cookies.Add(new HttpCookie(name) { Expires = DateTime.Now.AddDays(-1) });
            }
        }

    }
}
