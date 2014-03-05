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
        protected int DicId
        {
            get
            {
                return GetQueryValue("DicId").ToInt();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataDicInfoList();
        }
        protected void BindDataDicInfoList()
        {
            var DataList = DataInfo.GetDataDicInfoListById(Id);
            this.rptDataDicList.DataSource = DataList;
            this.rptDataDicList.DataBind();
        }
        protected void rptPendingList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var DataDicInfoId = ((HiddenField)e.Item.FindControl("hfDataDicInfoId")).Value.ToInt();
                if(e.CommandName.ToLower() == "Delete")
                {
                        DataInfo.DeleteDataDicInfo(DataDicInfoId);
                        RefreshSelf();
                }
            }
        }
            private void RefreshSelf()
        {
            PageRegisterStartupScript(this.Page, string.Format("<script type=\"text/javascript\">{0}</script>", "RefreshSelf()"));
        }

    }
}