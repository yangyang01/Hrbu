using Hrbu.Teaching.BusinessView.Model.Power;
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
    public partial class DataAddUp : BasePage
    {
        public IPower power { get; set; }
        public int DicId
        {
            get
            {
                return GetQueryValue("DicId").ToInt();
            }
        }
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
                    var data = power.GetDataDicInfoById(Id, DicId);

                    this.txtDataName.Text = data.InfoName;
                }
            }
        }
        protected void btClickSubmit(object sender, EventArgs e)
        {
            if (Request["DicId"] != null && Request["Id"] != null)
            {
                var dataDicInfo = power.GetDataDicInfoById(Id, DicId);

                dataDicInfo.InfoName = this.txtDataName.Text;
                power.UpdateDataDic(dataDicInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));
            }
            else
            {
                DataDicInfoUI dataInfo = new DataDicInfoUI();
                dataInfo.InfoName = this.txtDataName.Text;
                dataInfo.DataDicId = DicId;
                power.AddDataDic(dataInfo);
                WebMessageBox(this.Page, string.Format("'操作成功!',RefreshParentAndCloseSelf"));

            }
        }
        private void RefreshParentAndCloseSelf()
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "RefreshParentAndCloseSelf();", true);
        }

        private void RefreshParentAndSelf(string idstr)
        {
            string js = "RefreshParentAndSelf(" + idstr + ")";
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), js, true);
        }
    }
}