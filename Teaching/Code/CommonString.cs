using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WS.Eka.HTHR.WebUI
{
    public class CommonString
    {
        #region QueryString

        public const string MaterialCode = "MaterialCode";
        public const string DrawingType = "DrawingType";

        #endregion

        #region  QueryStringValue

        public const string DrawingTypeBuyItem = "BuyItem";
        public const string DrawingTypeMakeItem = "MakeItem";

        #endregion

        public const string PrefixCILAccount = @"K2SQL:";
        public const string UploadMaterialFilePath = @"../UploadFolder";
        public const string UploadMaterialExcelModelName = @"UploadMaterialExcelModel.xls";
        public const string MakeItemSummaryReportName = @"MakeItemSummaryReport.xls";
        public const int UploadFileSize = 1048576 * 2;   //最大上传文件大小2M


        public const string ReturnApplicationCommentStatus = "Return";
        public const string ForwardApplicationCommentStatus = "Forward";

        public const string MFC = "MFC";
        public const string NPI = "NPI";

        public const string MakeItemValue = "MakeItem";
        public const string BuyItemValue = "BuyItem";

        public const string CapexQueryString = "Capex";
        public const string CapexValue = "CAPEX";
        public const string PaymentTypeQueryString = "PaymentType";

        public const int PageSize = 10;
    }
}