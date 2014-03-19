using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.BusinessView.Model.Power;
using Hrbu.Teaching.WebUI.Code;

namespace Teaching.Pages.Power
{
    public partial class UserAddUp : BasePage
    {
        public IPower UserService { get; set; }
        public int Id
        {
            get
            {
                return GetQueryValue("Id").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["Id"] != null)
                {
                    BindModel();
                }
                this.ddlRoleName.BindRoleDropDownListWithDefault();
            }
        }
        protected void BindModel()
        {
            var userInfo = UserService.GetUserInfoById(Id);
            this.txtUserNo.Text = userInfo.User.UserNo;
            this.txtUserName.Text = userInfo.User.UserName;
            this.ddlRoleName.SelectedValue = userInfo.User.RoleId.ToString();
        }
        protected void ClickbtnSure(object sender, EventArgs e)
        {
            if (Request["Id"] != null)
            {
                var userInfo = UserService.GetUserInfoById(Id);

                userInfo.User.UserNo = this.txtUserNo.Text;
                userInfo.User.UserName = this.txtUserName.Text;
                userInfo.User.RoleId = this.ddlRoleName.SelectedValue.ToInt();
                UserService.UpdateUser(userInfo.User);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                UserUI user = new UserUI();
                user.UserNo = this.txtUserNo.Text;
                user.UserName = this.txtUserName.Text;
                user.RoleId = this.ddlRoleName.SelectedValue.ToInt();
                UserService.AddUser(user);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
        }
    }
}