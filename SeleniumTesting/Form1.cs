using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using ClosedXML.Excel;
using System.Threading;
using System.Diagnostics;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;
using System.Data;
using DocumentFormat.OpenXml.Drawing;

namespace SeleniumTesting
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            InitTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitTable()
        {

        }

        private void UseExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                string filePath = "Output " + System.DateTime.Now.ToString("dd.MM.yy") + ".xlsx";

                int lastRowIndex = ResultTable.RowCount - 2;

                int newRange = worksheet.RowsUsed().Count();

                DataGridViewRow lastRow = ResultTable.Rows[lastRowIndex];

                for (int col = 0; col < ResultTable.ColumnCount; col++)
                {   //INIT HEADERS
                    worksheet.Cell(1, col + 1).Value = ResultTable.Columns[col].HeaderText;
                    worksheet.Cell(1, col + 1).Style.Font.Bold = true;

                    worksheet.Cell(newRange + 1, col + 1).Value = lastRow.Cells[col].Value?.ToString();
                }
                
                workbook.SaveAs(filePath);
            }
        }

        private void WebTest()
        {
            if (ResultTable.Rows.Count == 1) return;

            IWebDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://seleniumbase.io/demo_page");

            foreach (DataGridViewRow row in ResultTable.Rows)
            {
                if (row.Index == ResultTable.Rows.Count - 1) continue;

                string textInput = row.Cells["Value"].Value?.ToString();
                string locator = row.Cells["Locator"].Value?.ToString();
                string ID = row.Cells["ID"].Value?.ToString();
                string action = row.Cells["Action"].Value?.ToString();

                PerformAction(locator, ID, action, textInput, driver, row);

                UseExcel();
            }
                driver.Quit();
        }
        


        public void PerformAction(string locator, string ID, string action, string textInput, IWebDriver driver, DataGridViewRow row)
        {
            IWebElement element = null;

            try
            {
                switch (locator.ToLower())
                {
                    case "id":
                        element = driver.FindElement(By.Id(ID));
                        break;

                    case "name":
                        element = driver.FindElement(By.Name(ID));
                        break;

                    case "xpath":
                        element = driver.FindElement(By.XPath(ID));
                        break;

                    case "css":
                        element = driver.FindElement(By.CssSelector(ID));
                        break;
                }
                switch (action.ToLower())
                {
                    case "type":
                        element.SendKeys(textInput);
                        row.Cells["Status"].Value = true;
                        break;

                    case "click":
                        element.Click();
                        row.Cells["Status"].Value = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                row.Cells["Status"].Value = false;
                row.Cells["Exception"].Value = ex.Message;
            }
            finally
            {
                Thread.Sleep(5000);
            }
        }
        private void StartTest_Click(object sender, EventArgs e)
        {
            WebTest();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ResultTable.Rows.Clear();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            ResultTable.ClearSelection();
        }

        private void ResultTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ResultTable.Columns[e.ColumnIndex].Name == "Remove")
            {
                DataGridViewRow row = ResultTable.Rows[e.RowIndex];

                if (row.IsNewRow) return;

                ResultTable.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
