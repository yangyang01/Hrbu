using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Interface;

namespace Teaching.Pages.Power
{
    public partial class DateBasicInfo : BasePage
    {
        public IPower DataInfo{get;set;}
        protected int Id
        {
            get
            {
                return GetQueryValue("Id").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataDicInfoList();
        }
        protected void BindDataDicInfoList()
        {
            var studentList = DataInfo.GetDataDicInfoListById(Id);
            this.rptDataDicList.DataSource = studentList;
            this.rptDataDicList.DataBind();
        }

    }
}