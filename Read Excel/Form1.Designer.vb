<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        btnBrowse = New Button()
        Label1 = New Label()
        txtFileName = New TextBox()
        Label2 = New Label()
        cboSheet = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 312)
        DataGridView1.TabIndex = 0
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(749, 330)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(39, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 334)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 2
        Label1.Text = "File Name :"
        ' 
        ' txtFileName
        ' 
        txtFileName.Location = New Point(84, 330)
        txtFileName.Name = "txtFileName"
        txtFileName.ReadOnly = True
        txtFileName.Size = New Size(659, 23)
        txtFileName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 372)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 4
        Label2.Text = "Sheet :"
        ' 
        ' cboSheet
        ' 
        cboSheet.FormattingEnabled = True
        cboSheet.Location = New Point(84, 369)
        cboSheet.Name = "cboSheet"
        cboSheet.Size = New Size(121, 23)
        cboSheet.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cboSheet)
        Controls.Add(Label2)
        Controls.Add(txtFileName)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(DataGridView1)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Read Excel"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSheet As ComboBox

End Class
