Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet

Namespace SpreadsheetImportDataTable
	Partial Public Class Form1
		Inherits Form
		Private workbook As IWorkbook = Nothing

		Public Sub New()
			InitializeComponent()
			workbook = spreadsheetControl1.Document

			' Initialize single worksheet
			'workbook.CreateNewDocument();
			Dim count As Integer = workbook.Worksheets.Count
			For i As Integer = count - 1 To 1 Step -1
				workbook.Worksheets.RemoveAt(i)
			Next i
			workbook.Worksheets(0).Name = "Default"
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Import DataTable according to the selected cell
			Dim activeWorksheet As Worksheet = workbook.Worksheets.ActiveWorksheet
            Dim selection As CellRange = activeWorksheet.SelectedCell

            spreadsheetControl1.BeginUpdate()
			activeWorksheet.Import(ManualDataSet.CreateData().Tables(0), True, selection.TopRowIndex, selection.LeftColumnIndex)
			spreadsheetControl1.EndUpdate()
		End Sub
	End Class
End Namespace