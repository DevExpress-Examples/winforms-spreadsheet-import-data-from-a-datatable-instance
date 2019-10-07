using System;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace SpreadsheetImportDataTable {
    public partial class Form1 : Form {
        private IWorkbook workbook = null;
        
        public Form1() {
            InitializeComponent();
            workbook = spreadsheetControl1.Document;

            // Initialize single worksheet
            //workbook.CreateNewDocument();
            int count = workbook.Worksheets.Count;
            for (int i = count - 1; i >= 1; i--)
                workbook.Worksheets.RemoveAt(i);
            workbook.Worksheets[0].Name = "Default";
        }

        private void button1_Click(object sender, EventArgs e) {
            // Import DataTable according to the selected cell
            Worksheet activeWorksheet = workbook.Worksheets.ActiveWorksheet;
            CellRange selection = activeWorksheet.SelectedCell;

            spreadsheetControl1.BeginUpdate();
            activeWorksheet.Import(ManualDataSet.CreateData().Tables[0], true, selection.TopRowIndex, selection.LeftColumnIndex);
            spreadsheetControl1.EndUpdate();
        }
    }
}