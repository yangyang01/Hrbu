using Hrbu.Teaching.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.BusinessView.Model.BasicInfo;
using Hrbu.Teaching.WebUI.Code;

namespace Teaching.Pages.BasicInfo
{
    public partial class StudentInfoDetail : BasePage
    {
        public IBasicInfo StudentService { get; set; }
        public IPower UserService { get; set; }
        public string Status
        {
            get
            {
                return GetQueryValue("Status");
            }
        }

        public bool IsView
        {
            get
            {
                return Status.ToUpper() == "View" || string.IsNullOrEmpty(Status);
            }
        }
        public int StudentId
        {
            get
            {
                return GetQueryValue("StudentId").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["StudentId"] != null)
                {
                    BindModel();
                }
                if (IsView)
                {
                    this.btnSubmit.Visible = true;
                    this.btnReset.Visible = true;
                }
                this.ddlMajor.BindDropDownListWithDefault(3);
            }
        }
        protected void BindModel()
        {
            var studentInfo = StudentService.GetStudengInfoById(StudentId);
            this.txtStuNo.Text = studentInfo.StudentNo;
            this.txtSex.Text = studentInfo.Sex;
            this.txtTel.Text = studentInfo.Tel;
            this.ddlMajor.SelectedValue = studentInfo.Major.NullToString();
            this.txtClass.Text = studentInfo.Class;
            this.txtZipCode.Text = studentInfo.ZipCope;
            this.txtAddress.Text = studentInfo.Address;
            this.txtContacts.Text = studentInfo.Contacts;
            this.txtContTel.Text = studentInfo.ConttactTel;
            this.txtMail.Text = studentInfo.Mail;
        }
        protected void ClickbtnSubmit(object sender, EventArgs e)
        {
            if (Request["StudentId"] != null)
            {
                var studentInfo = StudentService.GetStudengInfoById(StudentId);
                studentInfo.StudentNo = this.txtStuNo.Text;
                studentInfo.Sex = this.txtSex.Text;
                studentInfo.Tel = this.txtTel.Text;
                studentInfo.Major = this.ddlMajor.SelectedValue.ToInt();
                studentInfo.Class = this.txtClass.Text;
                studentInfo.ZipCope = this.txtZipCode.Text;
                studentInfo.Address = this.txtAddress.Text;
                studentInfo.Contacts = this.txtContacts.Text;
                studentInfo.ConttactTel = this.txtContTel.Text;
                studentInfo.Mail = this.txtMail.Text;
                StudentService.UpdateStudentInfo(studentInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                if (!UserService.IsExitUserNo(this.txtStuNo.Text))
                {
                    WebMessageBox(this.Page, "'请确定存在该用户！'");
                }
                else
                {
                    var user = UserService.GetUserInfoByNo(this.txtStuNo.Text);
                    if (!UserService.IsStudentNo(user.RoleId))
                    {
                        WebMessageBox(this.Page, "'请确定该用户为学生用户！'");
                    }
                    else
                    {
                        if (!StudentService.IsExitStudentNo(this.txtStuNo.Text))
                        {
                            StudentBasicInfoUI studentInfo = new StudentBasicInfoUI();
                            studentInfo.StudentNo = this.txtStuNo.Text;
                            studentInfo.Name = user.UserName;
                            studentInfo.Sex = this.txtSex.Text;
                            studentInfo.Tel = this.txtTel.Text;
                            studentInfo.Major = this.ddlMajor.SelectedValue.ToInt();
                            studentInfo.Class = this.txtClass.Text;
                            studentInfo.ZipCope = this.txtZipCode.Text;
                            studentInfo.Address = this.txtAddress.Text;
                            studentInfo.Contacts = this.txtContacts.Text;
                            studentInfo.ConttactTel = this.txtContTel.Text;
                            studentInfo.Mail = this.txtMail.Text;
                            StudentService.AddStudentInfo(studentInfo);
                            WebMessageBox(this.Page, string.Format("'保存成功!',RefreshParentAndCloseSelf"));
                        }
                        else
                        {
                            WebMessageBox(this.Page, "'已存在该学生信息'");
                        }
                    }
                }
            }
        }
    }
}