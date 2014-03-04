using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace Teaching
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Content/js/Scripts/WebForms/WebForms.js",
                            "~/Content/js/Scripts/WebForms/WebUIValidation.js",
                            "~/Content/js/Scripts/WebForms/MenuStandards.js",
                            "~/Content/js/Scripts/WebForms/Focus.js",
                            "~/Content/js/Scripts/WebForms/GridView.js",
                            "~/Content/js/Scripts/WebForms/DetailsView.js",
                            "~/Content/js/Scripts/WebForms/TreeView.js",
                            "~/Content/js/Scripts/WebForms/WebParts.js"));

            // 若要使这些文件正常工作，采用适当的顺序是非常重要的；这些文件具有显式依赖关系
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Content/js/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Content/js/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Content/js/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Content/js/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // 使用要用于开发和学习的 Modernizr 开发版本。然后，在准备好进行生产时，
            // 使用 http://modernizr.com 上的生成工具来仅选取所需的测试
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Content/js/Scripts/modernizr-*"));

            ScriptManager.ScriptResourceMapping.AddDefinition(
                "respond",
                new ScriptResourceDefinition
                {
                    Path = "~/Content/js/Scripts/respond.min.js",
                    DebugPath = "~/Content/js/Scripts/respond.js",
                });
        }
    }
}