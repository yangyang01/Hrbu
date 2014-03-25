using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teaching.Pages.Power
{
    public partial class LimitDetail : BasePage
    {
        public IPower powerInfo { get; set; }

        public int RoleId
        {
            get
            {
                string str_id = Request.QueryString["Id"];
                int id = 0;
                int.TryParse(str_id, out id);
                return id;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitialData();
            }
        }

        private void InitialData()
        {
            this.Power.Checked = powerInfo.RoleHasPermission(this.Power.Text, RoleId);
            foreach (ListItem item in this.power_sub.Items)
            {
                item.Selected = powerInfo.RoleHasPermission(item.Text, RoleId);
            }
            this.BasicInfo.Checked = powerInfo.RoleHasPermission(this.BasicInfo.Text, RoleId);
            foreach (ListItem item in this.basicinfo_sub.Items)
            {
                item.Selected = powerInfo.RoleHasPermission(item.Text, RoleId);
            }
            this.TeachFile.Checked = powerInfo.RoleHasPermission(this.TeachFile.Text, RoleId);
            foreach (ListItem item in this.teachfile_sub.Items)
            {
                item.Selected = powerInfo.RoleHasPermission(item.Text, RoleId);
            }
            this.CourseSchedule.Checked = powerInfo.RoleHasPermission(this.CourseSchedule.Text, RoleId);
            foreach (ListItem item in this.courceSchedule_sub.Items)
            {
                item.Selected = powerInfo.RoleHasPermission(item.Text, RoleId);
            }
            //others
            this.chbPracticeMg.Checked = powerInfo.RoleHasPermission(this.chbPracticeMg.Text, RoleId);
            this.chbReportsMg.Checked = powerInfo.RoleHasPermission(this.chbReportsMg.Text, RoleId);
            this.chbRulesMg.Checked = powerInfo.RoleHasPermission(this.chbRulesMg.Text, RoleId);
            this.chbStudentsMg.Checked = powerInfo.RoleHasPermission(this.chbStudentsMg.Text, RoleId);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ChangeMenuAuth(this.Power);
            foreach (ListItem item in this.power_sub.Items)
            {
                ChangeMenuAuth(item);
            }
            ChangeMenuAuth(this.BasicInfo);
            foreach (ListItem item in this.basicinfo_sub.Items)
            {
                ChangeMenuAuth(item);
            }
            ChangeMenuAuth(this.TeachFile);
            foreach (ListItem item in this.teachfile_sub.Items)
            {
                ChangeMenuAuth(item);
            }
            ChangeMenuAuth(this.CourseSchedule);
            foreach (ListItem item in this.courceSchedule_sub.Items)
            {
                ChangeMenuAuth(item);
            }
            //others
            ChangeMenuAuth(this.chbPracticeMg);
            ChangeMenuAuth(this.chbReportsMg);
            ChangeMenuAuth(this.chbRulesMg);
            ChangeMenuAuth(this.chbStudentsMg);

            WebMessageBox(this.Page, "保存成功！");
        }
        private void ChangeMenuAuth(ListItem obj)
        {
            if (obj != null && obj.Selected)
            {
                var data = powerInfo.GetAuthInfoByMenuAndRole(obj.Text, RoleId);
                if (data == null)
                {
                    AuthorizationsUI auth = new AuthorizationsUI()
                    {
                        MenuId = powerInfo.GetMenuIdByName(obj.Text),
                        MenuName = obj.Text,
                        RoleId = RoleId,
                        Enable = true
                    };
                    powerInfo.AddAuth(auth);
                }
                else
                {
                    data.Enable = true;
                    powerInfo.UpdateAuth(data);
                }
            }
        }
        private void ChangeMenuAuth(CheckBox obj)
        {
            if (obj != null)
            {
                var data = powerInfo.GetAuthInfoByMenuAndRole(obj.Text, RoleId);
                if (data == null)
                {
                    AuthorizationsUI auth = new AuthorizationsUI()
                    {
                        MenuId = powerInfo.GetMenuIdByName(obj.Text),
                        MenuName = obj.Text,
                        RoleId = RoleId
                    };
                    if (obj.Checked)
                    {
                        auth.Enable = true;
                    }
                    else
                    {
                        auth.Enable = false;
                    }
                    powerInfo.AddAuth(auth);
                }
                else
                {
                    data.MenuName = obj.Text;
                    data.RoleId = RoleId;
                    data.Enable = false;
                    powerInfo.UpdateAuth(data);
                }
            }
        }

    }
}