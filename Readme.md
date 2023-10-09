<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613725/19.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4776)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Spreadsheet for WinForms - How to Import Data from a DataTable Instance

This example illustrates how to import data from the [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable) instance into a [SpreadsheetControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraSpreadsheet.SpreadsheetControl). We use the [WorksheetExtensions.Import](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.WorksheetExtensions.Import.overloads) overloaded method from the [WorksheetExtensions](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.WorksheetExtensions) class located in the `DevExpress.Docs.dll` assembly. In addition, use the `WorksheetCollection.ActiveWorksheet` and `Worksheet.SelectedCell` properties to place the data relative to the selection in the SpreadsheetControl.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [ManualDataSet.cs](./CS/ManualDataSet.cs) (VB: [ManualDataSet.vb](./VB/ManualDataSet.vb))

## More Examples

* [How to import data to worksheet cells from different data sources](https://github.com/DevExpress-Examples/how-to-import-data-from-different-data-sources-and-use-tables)

## Documentation

* [Data Binding](https://docs.devexpress.com/WindowsForms/117679/controls-and-libraries/spreadsheet/data-binding)
