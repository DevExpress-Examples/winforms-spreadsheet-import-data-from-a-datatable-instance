Imports System.Data
Imports System.ComponentModel

Namespace SpreadsheetImportDataTable

    Public Class ManualDataSet
        Inherits DataSet

        Public Sub New()
            MyBase.New()
            Dim table As DataTable = New DataTable("table")
            DataSetName = "ManualDataSet"
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("MyDateTime", GetType(Date))
            table.Columns.Add("MyRow", GetType(String))
            table.Columns.Add("MyData", GetType(Double))
            table.Constraints.Add("IDPK", table.Columns("ID"), True)
            Tables.AddRange(New DataTable() {table})
        End Sub

        Public Shared Function CreateData() As ManualDataSet
            Dim ds As ManualDataSet = New ManualDataSet()
            Dim table As DataTable = ds.Tables("table")
            table.Rows.Add(New Object() {0, Date.Today, "A", 103})
            table.Rows.Add(New Object() {1, Date.Today, "B", 200})
            table.Rows.Add(New Object() {2, Date.Today, "C", 446})
            Return ds
        End Function

'#Region "Disable Serialization for Tables and Relations"
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overloads ReadOnly Property Tables As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overloads ReadOnly Property Relations As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property
'#End Region  ' Disable Serialization for Tables and Relations
    End Class
End Namespace
