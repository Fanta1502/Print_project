<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.listFiles = New System.Windows.Forms.CheckedListBox()
        Me.selectAll = New System.Windows.Forms.CheckBox()
        Me.txtFromPage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.both = New System.Windows.Forms.CheckBox()
        Me.incolor = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtToPage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumberOfCopie = New System.Windows.Forms.TextBox()
        Me.cbPrinter = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(931, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1098, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Print Files"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listFiles
        '
        Me.listFiles.CheckOnClick = True
        Me.listFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listFiles.FormattingEnabled = True
        Me.listFiles.Location = New System.Drawing.Point(36, 12)
        Me.listFiles.Name = "listFiles"
        Me.listFiles.Size = New System.Drawing.Size(875, 334)
        Me.listFiles.TabIndex = 3
        '
        'selectAll
        '
        Me.selectAll.AutoSize = True
        Me.selectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectAll.Location = New System.Drawing.Point(71, 376)
        Me.selectAll.Name = "selectAll"
        Me.selectAll.Size = New System.Drawing.Size(107, 28)
        Me.selectAll.TabIndex = 4
        Me.selectAll.Text = "Select all"
        Me.selectAll.UseVisualStyleBackColor = True
        '
        'txtFromPage
        '
        Me.txtFromPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromPage.Location = New System.Drawing.Point(120, 440)
        Me.txtFromPage.Name = "txtFromPage"
        Me.txtFromPage.Size = New System.Drawing.Size(100, 28)
        Me.txtFromPage.TabIndex = 5
        Me.txtFromPage.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From"
        '
        'both
        '
        Me.both.AutoSize = True
        Me.both.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.both.Location = New System.Drawing.Point(231, 376)
        Me.both.Name = "both"
        Me.both.Size = New System.Drawing.Size(119, 28)
        Me.both.TabIndex = 7
        Me.both.Text = "Both sides"
        Me.both.UseVisualStyleBackColor = True
        '
        'incolor
        '
        Me.incolor.AutoSize = True
        Me.incolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incolor.Location = New System.Drawing.Point(386, 376)
        Me.incolor.Name = "incolor"
        Me.incolor.Size = New System.Drawing.Size(94, 28)
        Me.incolor.TabIndex = 8
        Me.incolor.Text = "In color"
        Me.incolor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "to"
        '
        'txtToPage
        '
        Me.txtToPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToPage.Location = New System.Drawing.Point(286, 438)
        Me.txtToPage.Name = "txtToPage"
        Me.txtToPage.Size = New System.Drawing.Size(100, 28)
        Me.txtToPage.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "pages"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Number of copies"
        '
        'txtNumberOfCopie
        '
        Me.txtNumberOfCopie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfCopie.Location = New System.Drawing.Point(250, 491)
        Me.txtNumberOfCopie.Name = "txtNumberOfCopie"
        Me.txtNumberOfCopie.Size = New System.Drawing.Size(100, 28)
        Me.txtNumberOfCopie.TabIndex = 12
        Me.txtNumberOfCopie.Text = "1"
        '
        'cbPrinter
        '
        Me.cbPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrinter.FormattingEnabled = True
        Me.cbPrinter.Location = New System.Drawing.Point(519, 489)
        Me.cbPrinter.Name = "cbPrinter"
        Me.cbPrinter.Size = New System.Drawing.Size(307, 30)
        Me.cbPrinter.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(416, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Printer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 570)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbPrinter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumberOfCopie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtToPage)
        Me.Controls.Add(Me.incolor)
        Me.Controls.Add(Me.both)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFromPage)
        Me.Controls.Add(Me.selectAll)
        Me.Controls.Add(Me.listFiles)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Print"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents listFiles As CheckedListBox
    Friend WithEvents selectAll As CheckBox
    Friend WithEvents txtFromPage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents both As CheckBox
    Friend WithEvents incolor As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtToPage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumberOfCopie As TextBox
    Friend WithEvents cbPrinter As ComboBox
    Friend WithEvents Label5 As Label
End Class
