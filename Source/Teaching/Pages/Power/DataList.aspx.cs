using Hrbu.Teaching.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hrbu.Teaching.WebUI;
using Hrbu.Teaching.WebUI.UserControls;
using Hrbu.Teaching.Utility;

namespace Teaching.Pages.Power
{
    
    public partial class Datalist : BasePage
    {
        public IPower powerInfo { get; set; }
        protected int ID
        {
            get
            {
                return GetQueryValue("ID").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            PagerControl.PageChange += new PagerControl.PageRefresh(BindDataList);
            if (!IsPostBack)
            {
                BindDataList();
            }
        }
        protected void BindDataList(int currentPageIndex = 0)
        {
            int totalCount = 0;
            var dataDicList = powerInfo.GetDataInfoByPage(currentPageIndex + 1, 2, out totalCount);
            this.rptDateList.DataSource = dataDicList;
            this.rptDateList.DataBind();
            PagerControl.CurrentPageIndex = currentPageIndex;
            PagerControl.IntialProperties(totalCount);
        }
        //protected void NewData(Object sender, EventArgs e)
        //{
        //    string jsStr = "openDialog(\"/Pages/Power/DataAddUp.aspx\",400,200); ";
        //    ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), jsStr, true);
        //}
    }
}