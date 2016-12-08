using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.UI;

namespace ERP.General
{
    public partial class HelpForm : XtraForm
    {
        public HelpForm()
        {
            InitializeComponent();
            if (!User.IsAdmin) groupControl1.Visible = false;
            RefreshGrid();
        }

        void RefreshGrid()
        {
            gridControl1.DataSource = Functions.GetSqlServerDataTable(Variables.ConnectionString,
                "SELECT * FROM ERP_USERMANUALS");
        }

        public void DatabasePutFile(string path)
        {
            byte[] file;
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int) stream.Length);
                }
            }
            var con = new SqlConnection(Variables.ConnectionString);
            con.Open();
            using (var sqlWrite = new SqlCommand("INSERT INTO Raporty (RaportPlik) Values(@File)", con))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                sqlWrite.ExecuteNonQuery();
            }
            con.Close();
        }

        public void DatabaseReadFile(string id, string path)
        {
            var con = new SqlConnection(Variables.ConnectionString);
            con.Open();
            using (
                var sqlQuery = new SqlCommand(@"SELECT [RaportPlik] FROM [dbo].[Raporty] WHERE [RaportID] = @varID", con)
                )
            {
                sqlQuery.Parameters.AddWithValue("@varID", id);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                {
                    sqlQueryResult.Read();
                    var blob = new byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                    using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                        fs.Write(blob, 0, blob.Length);
                }
            }
        }

        public Stream DatabaseFileRead(string id)
        {
            MemoryStream memoryStream = new MemoryStream();
            var con = new SqlConnection(Variables.ConnectionString);
            con.Open();
            using (var sqlQuery = new SqlCommand(@"SELECT DOCUMENT FROM ERP_USERMANUALS WHERE ID = @ID", con))
            {
                sqlQuery.Parameters.AddWithValue("@ID", id);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                {
                    sqlQueryResult.Read();
                    var blob = new byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                    //using (var fs = new MemoryStream(memoryStream, FileMode.Create, FileAccess.Write)) {
                    memoryStream.Write(blob, 0, blob.Length);
                    //}
                }
            }
            Stream stream = memoryStream;
            return stream;
        }

        public int DatabaseFilePut(MemoryStream fileToPut)
        {
            int id = 0;
            byte[] file = fileToPut.ToArray();
            const string preparedCommand = @"
                    INSERT INTO [dbo].[Raporty]
                               ([RaportPlik])
                         VALUES
                               (@File)
                        SELECT [RaportID] FROM [dbo].[Raporty]
            WHERE [RaportID] = SCOPE_IDENTITY()
                    ";
            var con = new SqlConnection(Variables.ConnectionString);
            con.Open();
            using (var sqlWrite = new SqlCommand(preparedCommand, con))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;

                using (var sqlWriteQuery = sqlWrite.ExecuteReader())
                    while (sqlWriteQuery.Read())
                    {
                        id = sqlWriteQuery["RaportID"] as int? ?? 0;
                    }
            }
            return id;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ERPDocumentViewer reporting = new ERPDocumentViewer();
            reporting.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            ERPDocumentViewer reporting = new ERPDocumentViewer();
            reporting.richEdit.DocumentLoaded += RichEditOnDocumentLoaded;
           
            reporting.richEdit.Document.LoadDocument(DatabaseFileRead(row["ID"].ToString()), DocumentFormat.Doc);
            reporting.ShowDialog();
        }

        public static class MyFactoryHelper
        {
            public static void SetMyNewCommandFactory(RichEditControl control)
            {
                var myCommandFactory = new CustomRichEditCommandFactoryService(control,
                    control.GetService<IRichEditCommandFactoryService>());
                control.ReplaceService<IRichEditCommandFactoryService>(myCommandFactory);
            }
        }

        private void RichEditOnDocumentLoaded(object sender, EventArgs eventArgs)
        {



        }

        public class CustomRichEditCommandFactoryService : IRichEditCommandFactoryService
        {
            readonly IRichEditCommandFactoryService service;
            readonly RichEditControl control;

            public CustomRichEditCommandFactoryService(RichEditControl control,
                IRichEditCommandFactoryService service)
            {
                this.control = control;
                this.service = service;
            }

            public RichEditCommand CreateCommand(RichEditCommandId id)
            {
                if (id == RichEditCommandId.FileSave)
                    return new CustomSaveDocumentCommand(control);
                return service.CreateCommand(id);
            }

            public class CustomSaveDocumentCommand : SaveDocumentAsCommand
            {
                public CustomSaveDocumentCommand(IRichEditControl control) : base(control)
                {

                }

                protected override void ExecuteCore()
                {
                    base.ExecuteCore();
                    string fileName = this.DocumentModel.DocumentSaveOptions.CurrentFileName;
                }
            }
        }
    }
}