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
    public partial class PassWordUpdate : BasePage
    {
        public ILogin loginService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Confirm_Button(object sender, EventArgs e)
        {
            CheckPass();
        }
        protected void CheckPass()
        {
            var user = loginService.GetUserInfoByNo(CurrentUser.UserNo);
            var oldPass = this.txtOldPass.Text;
            var newPass = this.txtNewPass.Text;
            var confirmPass = this.txtConfirmPass.Text;
            if (oldPass != null && oldPass != user.Password)
            {
                ShowErrorMeg("该用户密码错误！");
                return;
            }
            if (newPass != null && confirmPass != null && newPass != confirmPass)
            {
                ShowErrorMeg("请确认新密码！");
                return;
            }
            if (newPass != null && confirmPass != null && newPass == confirmPass && oldPass == user.Password)
            {
                user.Password = this.txtNewPass.Text;
                loginService.UpdatePass(user);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));

            }
        }
        private void ShowErrorMeg(string ErrorMeg)
        {
            this.lblErrorMeg.Visible = true;
            this.lblErrorMeg.Text = ErrorMeg;
        }
    }
}