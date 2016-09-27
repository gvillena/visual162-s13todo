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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbTask1 = New System.Windows.Forms.CheckBox()
        Me.cbTask2 = New System.Windows.Forms.CheckBox()
        Me.cbTask3 = New System.Windows.Forms.CheckBox()
        Me.cbTask4 = New System.Windows.Forms.CheckBox()
        Me.lblTask1 = New System.Windows.Forms.Label()
        Me.lblTask2 = New System.Windows.Forms.Label()
        Me.lblTask3 = New System.Windows.Forms.Label()
        Me.lblTask4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(378, 57)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(3, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(372, 29)
        Me.TextBox1.TabIndex = 99
        Me.TextBox1.Text = "¿Que planes para hoy?"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 10)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.37566!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.62434!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbTask1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbTask2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cbTask3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cbTask4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTask1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTask2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTask3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblTask4, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 112)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(378, 257)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'cbTask1
        '
        Me.cbTask1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTask1.AutoSize = True
        Me.cbTask1.BackColor = System.Drawing.Color.White
        Me.cbTask1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask1.ForeColor = System.Drawing.Color.Silver
        Me.cbTask1.Location = New System.Drawing.Point(15, 26)
        Me.cbTask1.Name = "cbTask1"
        Me.cbTask1.Size = New System.Drawing.Size(12, 11)
        Me.cbTask1.TabIndex = 0
        Me.cbTask1.ThreeState = True
        Me.cbTask1.UseVisualStyleBackColor = False
        Me.cbTask1.Visible = False
        '
        'cbTask2
        '
        Me.cbTask2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTask2.AutoSize = True
        Me.cbTask2.BackColor = System.Drawing.Color.White
        Me.cbTask2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask2.ForeColor = System.Drawing.Color.Silver
        Me.cbTask2.Location = New System.Drawing.Point(15, 90)
        Me.cbTask2.Name = "cbTask2"
        Me.cbTask2.Size = New System.Drawing.Size(12, 11)
        Me.cbTask2.TabIndex = 0
        Me.cbTask2.UseVisualStyleBackColor = False
        Me.cbTask2.Visible = False
        '
        'cbTask3
        '
        Me.cbTask3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTask3.AutoSize = True
        Me.cbTask3.BackColor = System.Drawing.Color.White
        Me.cbTask3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask3.ForeColor = System.Drawing.Color.Silver
        Me.cbTask3.Location = New System.Drawing.Point(15, 154)
        Me.cbTask3.Name = "cbTask3"
        Me.cbTask3.Size = New System.Drawing.Size(12, 11)
        Me.cbTask3.TabIndex = 0
        Me.cbTask3.UseVisualStyleBackColor = False
        Me.cbTask3.Visible = False
        '
        'cbTask4
        '
        Me.cbTask4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbTask4.AutoSize = True
        Me.cbTask4.BackColor = System.Drawing.Color.White
        Me.cbTask4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTask4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTask4.ForeColor = System.Drawing.Color.Silver
        Me.cbTask4.Location = New System.Drawing.Point(15, 219)
        Me.cbTask4.Name = "cbTask4"
        Me.cbTask4.Size = New System.Drawing.Size(12, 11)
        Me.cbTask4.TabIndex = 0
        Me.cbTask4.UseVisualStyleBackColor = False
        Me.cbTask4.Visible = False
        '
        'lblTask1
        '
        Me.lblTask1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask1.AutoSize = True
        Me.lblTask1.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask1.ForeColor = System.Drawing.Color.DimGray
        Me.lblTask1.Location = New System.Drawing.Point(46, 17)
        Me.lblTask1.Name = "lblTask1"
        Me.lblTask1.Size = New System.Drawing.Size(73, 30)
        Me.lblTask1.TabIndex = 1
        Me.lblTask1.Text = "Label1"
        Me.lblTask1.Visible = False
        '
        'lblTask2
        '
        Me.lblTask2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask2.AutoSize = True
        Me.lblTask2.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask2.ForeColor = System.Drawing.Color.DimGray
        Me.lblTask2.Location = New System.Drawing.Point(46, 81)
        Me.lblTask2.Name = "lblTask2"
        Me.lblTask2.Size = New System.Drawing.Size(73, 30)
        Me.lblTask2.TabIndex = 1
        Me.lblTask2.Text = "Label1"
        Me.lblTask2.Visible = False
        '
        'lblTask3
        '
        Me.lblTask3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask3.AutoSize = True
        Me.lblTask3.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask3.ForeColor = System.Drawing.Color.DimGray
        Me.lblTask3.Location = New System.Drawing.Point(46, 145)
        Me.lblTask3.Name = "lblTask3"
        Me.lblTask3.Size = New System.Drawing.Size(73, 30)
        Me.lblTask3.TabIndex = 1
        Me.lblTask3.Text = "Label1"
        Me.lblTask3.Visible = False
        '
        'lblTask4
        '
        Me.lblTask4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTask4.AutoSize = True
        Me.lblTask4.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask4.ForeColor = System.Drawing.Color.DimGray
        Me.lblTask4.Location = New System.Drawing.Point(46, 209)
        Me.lblTask4.Name = "lblTask4"
        Me.lblTask4.Size = New System.Drawing.Size(73, 30)
        Me.lblTask4.TabIndex = 1
        Me.lblTask4.Text = "Label1"
        Me.lblTask4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(402, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cbTask1 As CheckBox
    Friend WithEvents cbTask2 As CheckBox
    Friend WithEvents cbTask3 As CheckBox
    Friend WithEvents cbTask4 As CheckBox
    Friend WithEvents lblTask1 As Label
    Friend WithEvents lblTask2 As Label
    Friend WithEvents lblTask3 As Label
    Friend WithEvents lblTask4 As Label
End Class
