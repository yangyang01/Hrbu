using Hrbu.Teaching.WebUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teaching.Pages.Power
{
    public partial class BackUp : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnBak_Click(object sender, EventArgs e) //备份
        {
            string saveAway = this.tbxBakLoad.Text.ToString().Trim();
            string cmdText = @"backup database " + System.Configuration.ConfigurationManager.AppSettings["dbName"] + " to disk='" + saveAway + "'";
            BakReductSql(cmdText, true);
        }
        public void btnReduct_Click(object sender, EventArgs e)  //恢复
        {
            string openAway = this.tbxReductLoad.Text.ToString().Trim();//读取文件的路径
            string cmdText = @"restore database " + System.Configuration.ConfigurationManager.AppSettings["dbName"] + " from disk='" + openAway + "'";
            BakReductSql(cmdText, false);
        }
        /// <summary>
        /// 对数据库的备份和恢复操作，Sql语句实现
        /// </summary>
        /// <param name="cmdText">实现备份或恢复的Sql语句</param>
        /// <param name="isBak">该操作是否为备份操作，是为true否，为false</param>
        private void BakReductSql(string cmdText, bool isBak)
        {
            SqlCommand cmdBakRst = new SqlCommand();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;uid=sa;pwd=123;");
            try
            {
                conn.Open();
                cmdBakRst.Connection = conn;
                cmdBakRst.CommandType = CommandType.Text;
                if (!isBak)     //如果是恢复操作
                {
                    string setOffline = "Alter database GroupMessage Set Offline With rollback immediate ";
                    string setOnline = " Alter database GroupMessage Set Online With Rollback immediate";
                    cmdBakRst.CommandText = setOffline + cmdText + setOnline;
                }
                else
                {
                    cmdBakRst.CommandText = cmdText;
                }
                cmdBakRst.ExecuteNonQuery();
                if (!isBak)
                {
                    WebMessageBox(this.Page, string.Format("'恭喜你，数据成功恢复为所选文档的状态！", "系统消息'"));
                }
                else
                {
                    WebMessageBox(this.Page, string.Format("恭喜，你已经成功备份当前数据！", "系统消息"));
                }
            }
            catch (SqlException sexc)
            {
                WebMessageBox(this.Page, string.Format("失败，可能是对数据库操作失败，原因：" + sexc, "数据库错误消息"));
            }
            catch (Exception ex)
            {
                WebMessageBox(this.Page, string.Format("对不起，操作失败，可能原因：" + ex, "系统消息"));

            }
            finally
            {
                cmdBakRst.Dispose();
                conn.Close();
                conn.Dispose();
            }
        }
    }
}