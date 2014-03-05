using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.Utility;
using Microsoft.AspNet.Identity;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Hrbu.Teaching.WebUI
{
    public partial class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            ObjectFactory.BuildUp(this);
        }

        public void checkAuth()
        {
            if (CurrentUser != null && !PowerService.RoleHasPermission(this.PageName, CurrentUser.RoleId))
            {
                Response.Write("对不起，你没有访问该站点的权限，如有疑问，请联系管理员！");
                Response.End();
            }
        }

        protected IPower PowerService
        { get; set; }

        public virtual string PageName
        {
            get
            {
                return "basepage";
            }
        }

        public UserUI CurrentUser
        {
            get
            {
                if (Session["currentUser"] == null)
                {
                    Session["currentUser"] = new UserUI();
                }
                return Session["currentUser"] as UserUI;
            }
        }

        public string GetQueryValue(string name)
        {
            if (string.IsNullOrWhiteSpace(Request.QueryString[name]))
                return "";
            else
                return Request.QueryString[name].Trim();
        }

        //Register Startup Script
        public void PageRegisterStartupScript(System.Web.UI.Page page, string script)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "", script);
        }

        //Show Alert Dialog
        public void WebMessageBox(System.Web.UI.Page page, string msg)
        {
            //PageRegisterStartupScript(page, string.Format("<script type=\"text/javascript\">ShowMessage({0})</script>", values));
            string[] s = msg.Split(',');
            string message = s[0].Replace("'", "");
            if (s.Length == 2)
            {
                WebMessageBox(page, message, s[1]);
            }
            else
            {
                WebMessageBox(page, message, null);
            }
        }
        public void WebMessageBox(System.Web.UI.Page page, string msg, string callback = null)
        {
            if (string.IsNullOrEmpty(callback))
                PageRegisterStartupScript(page, string.Format("<script type=\"text/javascript\">alert('{0}')</script>", msg));
            else
                PageRegisterStartupScript(page, string.Format("<script type=\"text/javascript\">alert('{0}',{1})</script>", msg, callback));
        }
    }
}
