using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.Utility;
using Hrbu.Teaching.Interface;
using Hrbu.Teaching.WebUI.UserControls;

namespace Teaching.Pages.TeachDocument
{
    public partial class SyllabusDetail : BasePage
    {
        public ITeachDocument TeachingService { get; set; }

        public int BasicCode
        {
            get
            {
                return GetQueryValue("BasicCode").ToInt();
            }
        }
        public string CourseName
        {
            get
            {
                return GetQueryValue("CourseName").ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PagerControl.PageChange += new PagerControl.PageRefresh(BindSyllabusDetailList);
            if (!IsPostBack)
            {
                BindSyllabusDetailList();

            }
        }

        protected void BindSyllabusDetailList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var TeachingList = TeachingService.GetTeachingSyllabusDetailByPage(BasicCode, currentPageIndex + 1, PagerControl.PageSize, out totalCount);
            this.rptSyllabusDetailList.DataSource = TeachingList;
            this.rptSyllabusDetailList.DataBind();
            if (totalCount == 0)
            {
                this.phNoData.Visible = true;
                this.trPage.Visible = false;
            }
            else
            {
                this.phNoData.Visible = false;
                this.trPage.Visible = true;
            }
            PagerControl.CurrentPageIndex = currentPageIndex;
            PagerControl.IntialProperties(totalCount);
        }
    }
}