using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Hrbu.Teaching.Utility
{
    public static class ExcelHelper
    {
        /// <summary>
        /// Read excel to DataTable
        /// </summary>
        /// <param name="filePath">excel文件完整路径</param>
        /// <returns>excel里面指定的sheetName</returns>
        public static DataSet ReadAsDataSet(string filePath, string sheetName)
        {
            var connectString = GetExcelProviderString(filePath);

            if (!string.IsNullOrEmpty(connectString))
            {
                using (OleDbConnection connection = new OleDbConnection(connectString))
                {
                    connection.Open();

                    var table = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                    List<string> workBooks = new List<string>();

                    foreach (DataRow row in table.Rows)
                    {
                        var sheet_name = row["Table_Name"].ObjectToString();
                        if (sheet_name.EndsWith("$") && !sheet_name.Contains("_FilterDatabase"))
                        {
                            workBooks.Add(sheet_name);
                        }
                    }

                    if (workBooks.Count > 0 && workBooks.Contains(sheetName + "$"))
                    {
                        var strExcel = string.Format("select * from [{0}]", sheetName + "$");
                        OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, connectString);
                        var ds = new DataSet();
                        myCommand.Fill(ds);
                        return ds;
                    }
                }
            }
            return null;

        }

        public static string GetExcelProviderString(string filePath)
        {
            var connectString = string.Empty;

            if (filePath.EndsWith("xls"))
            {
                connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""";
            }
            else if (filePath.EndsWith("xlsx"))
            {
                connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;HDR=YES;IMEX=1;""";
            }


            return string.Format(connectString.Trim(), filePath);
        }
    }
}
