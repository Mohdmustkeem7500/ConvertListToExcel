using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace MainApp
{
    static class ExcelExport
    {
        public static void GenerateExcel(DataTable dataTable, string path)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            // create a excel app along side with workbook and worksheet and give a name to it
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();
            Excel._Worksheet xlWorksheet = excelWorkBook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            

            //foreach (Excel.Range column in selectedRange.Columns)
            //{
            //    column.ColumnWidth = (double)column.ColumnWidth + 5;
            //}



            foreach (DataTable table in dataSet.Tables)
            {
                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;


                //Excel.Range selectedRange = (Excel.Range)excelApp.Selection;
                //selectedRange.Columns.AutoFit();
                //foreach (Excel.Range column in selectedRange.Columns)
                //{
                //    column.ColumnWidth = (double)column.ColumnWidth + 40;
                //}


                for (int j = 1; j <= table.Columns.Count; j++)
                {
                    Excel.Range selectedRange = (Excel.Range)excelApp.Selection;
                    Excel.Range column = selectedRange.Columns[j];
                    selectedRange.Columns.AutoFit();

                    //column.ColumnWidth = (double)column.ColumnWidth + 40;

                    int p = 1;
                    if (p == j)
                    {
                        column.ColumnWidth = (double)column.ColumnWidth + 30;
                    }
                    else
                    {
                        column.ColumnWidth = (double)column.ColumnWidth + 10;
                    }

                }

                // add all the columns
                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                    
                }

                // add all the rows
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }
            }
            excelWorkBook.SaveAs(path);
            excelWorkBook.Close();
            excelApp.Quit();
        }
    }
}
