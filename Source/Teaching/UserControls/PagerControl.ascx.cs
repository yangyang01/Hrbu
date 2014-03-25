using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hrbu.Teaching.WebUI.UserControls
{
    public partial class PagerControl : System.Web.UI.UserControl
    {
        public delegate void PageRefresh(int pageIndex);
        public event PageRefresh PageChange;

        protected int PageIndexCount = 7;

        protected int ActualPageIndex
        {
            get
            {
                if (TotalCount == 0) return 0;
                return CurrentPageIndex + 1;
            }
        }

        /// <summary>
        /// Index Start From 0
        /// </summary>
        public int CurrentPageIndex
        {
            set
            {
                int index = value;
                if (index <= 0)
                    index = 0;
                else if (index > TotalPage)
                    index = TotalPage - 1;
                ViewState["CurrentPageIndex"] = index;
            }
            get
            {
                if (ViewState["CurrentPageIndex"] == null)
                {
                    return 0;
                }
                return (int)ViewState["CurrentPageIndex"];
            }
        }

        /// <summary>
        /// Default Size 8
        /// </summary>
        public int PageSize
        {
            get
            {
                if (ViewState["PageSize"] == null)
                {
                    return 8;
                }
                else
                {
                    return (int)ViewState["PageSize"];
                }
            }
            set
            {
                ViewState["PageSize"] = value;
            }
        }

        public void IntialProperties(int totalCount, int pageSize = 8)
        {
            this.TotalCount = totalCount;
            PageSize = pageSize;
            this.lblAllPages.Text = this.TotalPage.ToString();

            IntialButton();
            BindPages();
        }

        #region Protected

        protected int TotalCount
        {
            set
            {
                ViewState["TotalCount"] = value;
            }
            get
            {
                if (ViewState["TotalCount"] == null)
                {
                    return 0;
                }
                return (int)ViewState["TotalCount"];
            }
        }
        protected int TotalPage
        {
            get
            {
                if (TotalCount % PageSize != 0)
                {
                    return TotalCount / PageSize + 1;
                }
                else
                {
                    return TotalCount / PageSize;
                }
            }
        }

        protected int PageStart
        {
            get
            {
                if (ActualPageIndex > PageIndexCount)
                    return ActualPageIndex - PageIndexCount;
                else
                    return 1;
            }
        }

        protected void lbtnFirstPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 0;
            PageSkip();
        }


        protected void lbtnPreviousPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex -= 1;
            PageSkip();
        }

        protected void lbtnNextPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex += 1;
            PageSkip();
        }

        protected void lbtnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalCount - 1;
            PageSkip();
        }

        protected void lbtnGoto_Click(object sender, EventArgs e)
        {
            var input = this.txtInputPage.Text;
            if (string.IsNullOrEmpty(input))
            {
                this.CurrentPageIndex = 0;
            }
            else
            {
                int pageindex = 1;
                Int32.TryParse(this.txtInputPage.Text, out pageindex);
                if (pageindex > TotalPage)
                    pageindex = TotalPage;
                this.CurrentPageIndex = pageindex - 1;
            }
            PageSkip();
        }

        protected void BindPages()
        {
            this.lblCurrentPage.Text = this.ActualPageIndex.ToString();
            this.txtInputPage.Text = this.ActualPageIndex.ToString();
        }

        protected void PageSkip()
        {
            BindPages();
            IntialButton();
            PageChange(CurrentPageIndex);
        }

        private void IntialButton()
        {
            if (TotalPage <= 1)
            {
                this.lbtnFirstPage.Enabled = false;
                this.lbtnPreviousPage.Enabled = false;
                this.lbtnNextPage.Enabled = false;
                this.lbtnLastPage.Enabled = false;
                this.lbtnGoto.Enabled = false;
            }
            else
            {
                if (ActualPageIndex == TotalPage)
                {
                    this.lbtnPreviousPage.Enabled = true;
                    this.lbtnFirstPage.Enabled = true;
                    this.lbtnNextPage.Enabled = false;
                    this.lbtnLastPage.Enabled = false;
                }
                else if (ActualPageIndex == 1)
                {
                    this.lbtnNextPage.Enabled = true;
                    this.lbtnLastPage.Enabled = true;
                    this.lbtnPreviousPage.Enabled = false;
                    this.lbtnFirstPage.Enabled = false;
                }
                else
                {
                    this.lbtnNextPage.Enabled = true;
                    this.lbtnLastPage.Enabled = true;
                    this.lbtnPreviousPage.Enabled = true;
                    this.lbtnFirstPage.Enabled = true;
                }

                this.lbtnGoto.Enabled = true;
            }

        }


        #endregion


    }
}