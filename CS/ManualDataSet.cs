using System;
using System.Data;
using System.ComponentModel;

namespace SpreadsheetImportDataTable {
    public class ManualDataSet : DataSet {
        public ManualDataSet()
            : base() {
            DataTable table = new DataTable("table");

            DataSetName = "ManualDataSet";

            table.Columns.Add("ID", typeof(Int32));
            table.Columns.Add("MyDateTime", typeof(DateTime));
            table.Columns.Add("MyRow", typeof(string));
            table.Columns.Add("MyData", typeof(double));
            table.Constraints.Add("IDPK", table.Columns["ID"], true);

            Tables.AddRange(new DataTable[] { table });
        }

        public static ManualDataSet CreateData() {
            ManualDataSet ds = new ManualDataSet();
            DataTable table = ds.Tables["table"];

            table.Rows.Add(new object[] { 0, DateTime.Today, "A", 103 });
            table.Rows.Add(new object[] { 1, DateTime.Today, "B", 200 });
            table.Rows.Add(new object[] { 2, DateTime.Today, "C", 446 });

            return ds;
        }

        #region Disable Serialization for Tables and Relations
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataTableCollection Tables {
            get { return base.Tables; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataRelationCollection Relations {
            get { return base.Relations; }
        }
        #endregion Disable Serialization for Tables and Relations
    }
}
