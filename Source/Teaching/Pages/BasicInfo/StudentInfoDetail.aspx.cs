using Hrbu.Teaching.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.WebUI;

namespace Teaching.Pages.BasicInfo
{
    public partial class StudentInfoDetail : BasePage
    {
        public IBasicInfo StudentService { get; set; }
        public string Status
        {
            get
            {
                return GetQueryValue("Status");
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
                BindModel();
            }
        }
        protected void BindModel()
        {
            var studentInfo = StudentService.GetStudengInfoById(StudentId);
            this.txtStuNo.Text = studentInfo.StudentNo;
            this.txtStuName.Text = studentInfo.Name;
            this.txtSex.Text = studentInfo.Sex;
            this.txtTel.Text = studentInfo.Tel;
            this.txtMajor.Text = studentInfo.Major.NullToString();
            this.txtClass.Text = studentInfo.Class;
            this.txtZipCode.Text = studentInfo.ZipCope;
            this.txtAddress.Text = studentInfo.Address;
            this.txtContacts.Text = studentInfo.Contacts;
            this.txtContTel.Text = studentInfo.ConttactTel;
            this.txtMail.Text = studentInfo.Mail;
        }
    }
}