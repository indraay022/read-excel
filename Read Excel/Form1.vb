Imports System.IO
Imports System.Text
Imports ExcelDataReader

Public Class Form1
    Dim tables As DataTableCollection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd = New OpenFileDialog With {.Filter = "Excel Workbook|*.xlsx"}
            If ofd.ShowDialog = DialogResult.OK Then
                txtFileName.Text = ofd.FileName

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader = ExcelReaderFactory.CreateReader(stream)
                        Dim result = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        cboSheet.Items.Clear()

                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        DataGridView1.DataSource = dt
    End Sub
End Class
