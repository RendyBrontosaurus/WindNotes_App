<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txttittle = New System.Windows.Forms.TextBox()
        Me.btnread = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtnotes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttittle
        '
        Me.txttittle.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txttittle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttittle.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttittle.Location = New System.Drawing.Point(12, 63)
        Me.txttittle.Multiline = True
        Me.txttittle.Name = "txttittle"
        Me.txttittle.Size = New System.Drawing.Size(388, 49)
        Me.txttittle.TabIndex = 2
        '
        'btnread
        '
        Me.btnread.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnread.FlatAppearance.BorderSize = 0
        Me.btnread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnread.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnread.Location = New System.Drawing.Point(406, 457)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(105, 49)
        Me.btnread.TabIndex = 4
        Me.btnread.Text = "Read"
        Me.btnread.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(517, 457)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(102, 49)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'txtnotes
        '
        Me.txtnotes.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtnotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnotes.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnotes.Location = New System.Drawing.Point(12, 118)
        Me.txtnotes.Multiline = True
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(388, 325)
        Me.txtnotes.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(444, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Notes List"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(12, 457)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(387, 49)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Add Note"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Notes, Me.Notess})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.PaleGoldenrod
        Me.DataGridView1.Location = New System.Drawing.Point(406, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkKhaki
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(213, 380)
        Me.DataGridView1.TabIndex = 12
        '
        'Notes
        '
        Me.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Notes.FillWeight = 200.0!
        Me.Notes.HeaderText = ""
        Me.Notes.MinimumWidth = 6
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'Notess
        '
        Me.Notess.HeaderText = "Notess"
        Me.Notess.MinimumWidth = 6
        Me.Notess.Name = "Notess"
        Me.Notess.ReadOnly = True
        Me.Notess.Visible = False
        Me.Notess.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(631, 519)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnotes)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnread)
        Me.Controls.Add(Me.txttittle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttittle As TextBox
    Friend WithEvents btnread As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtnotes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents Notess As DataGridViewTextBoxColumn
End Class
