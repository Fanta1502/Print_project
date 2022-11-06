Imports System.IO
Imports System.Management
Imports PdfiumViewer
Imports System.Data.DataTable
Imports MySql.Data.MySqlClient

Public Event PrintPage As System.Drawing.Printing.PrintPageEventHandler
Public Class Form1
    Dim path As String
    Dim numberOfPage As Int32
    Dim psi As New ProcessStartInfo
    Dim printButton As System.Windows.Forms.Button
    Dim printFont As Font
    Dim streamToPrint As StreamReader
    Dim namefile As String
    Dim printer As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Browse
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK Then
            'Test result.
            listFiles.Items.Clear()
            Dim grade As New System.IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            path = FolderBrowserDialog1.SelectedPath
            Dim inFiles As System.IO.FileInfo() = grade.GetFiles()
            Dim fLinfo As System.IO.FileInfo
            Dim strArr() As String
            For Each fLinfo In inFiles
                strArr = fLinfo.ToString().Split(".")
                If strArr(strArr.Length - 1) = "pdf" Or strArr(strArr.Length - 1) = "docx" Or strArr(strArr.Length - 1) = "doc" Or strArr(strArr.Length - 1) = "xlsx" Then
                    listFiles.Items.Add(fLinfo)
                End If
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'Print file
            Dim printerName As String = Nothing
            If cbPrinter.SelectedItem Is Nothing Then
                MessageBox.Show("Please choose a printer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim count As Int32 = listFiles.Items.Count
            If count > 0 Then
                Dim strArr() As String
                For Each file In listFiles.CheckedItems
                    strArr = file.ToString().Split(".")
                    namefile = path + "\" + file.ToString()
                    If strArr(strArr.Length - 1) = "pdf" Then
                        Dim doc As PdfDocument = PdfDocument.Load(namefile)
                        Dim print = doc.CreatePrintDocument()
                        print.DefaultPageSettings.Color = incolor.Checked
                        print.PrinterSettings.PrinterName = printer
                        print.PrinterSettings.FromPage = Convert.ToInt32(txtFromPage.Text)
                        print.PrinterSettings.Copies = Convert.ToInt32(txtNumberOfCopie.Text)
                        If txtToPage.Text IsNot "" Then
                            print.PrinterSettings.ToPage = Convert.ToInt32(txtToPage.Text)
                        End If
                        If print.PrinterSettings.CanDuplex = True And both.Checked = True Then
                            print.PrinterSettings.Duplex = both.Checked
                        ElseIf both.Checked = True And print.PrinterSettings.CanDuplex = False Then
                            Dim res = MessageBox.Show("Your printer does not support duplex ! 
Do you want to continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If res = DialogResult.No Then
                                Return
                            End If
                        Else
                        End If
                        Try
                            print.Print()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    ElseIf strArr(strArr.Length - 1) = "doc" Or strArr(strArr.Length - 1) = "docx" Then
                        Dim word_server As Microsoft.Office.Interop.Word.Application
                        Application.DoEvents()
                        Me.Cursor = Cursors.WaitCursor
                        Try
                            word_server = New Microsoft.Office.Interop.Word.Application
                        Catch ex As Exception
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("Error opening Word.Basic" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        Try
                            word_server.Documents.Open(FileName:=CType(namefile, Object), ReadOnly:=True, AddToRecentFiles:=False,
                                                       Format:=Microsoft.Office.Interop.Word.WdOpenFormat.wdOpenFormatAuto)
                        Catch ex As Exception
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("Error opening file 1 " & namefile & vbCrLf & ex.Message)
                            word_server.Quit(False)
                            Exit Sub
                        End Try
                        Try
                            word_server.ActivePrinter = printer
                            If txtToPage.Text IsNot "" Then
                                word_server.ActiveDocument.PrintOut(Range:=Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintFromTo,
                            Item:=Microsoft.Office.Interop.Word.WdPrintOutItem.wdPrintDocumentContent, Copies:=Convert.ToInt32(txtNumberOfCopie.Text),
                            Background:=False, From:=txtFromPage.Text, [To]:=txtToPage.Text, ManualDuplexPrint:=both.Checked)
                            Else
                                word_server.ActiveDocument.PrintOut(Range:=Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintAllDocument,
                            Item:=Microsoft.Office.Interop.Word.WdPrintOutItem.wdPrintDocumentContent, Copies:=Convert.ToInt32(txtNumberOfCopie.Text),
                            Background:=False, ManualDuplexPrint:=both.Checked)
                            End If
                        Catch ex As Exception
                            Me.Cursor = Cursors.Default
                            MessageBox.Show("Error opening file 2 " & namefile & vbCrLf & ex.Message)
                            word_server.ActiveDocument.Close(SaveChanges:=False)
                            word_server.Quit(False)
                            Exit Sub
                        End Try
                        Me.Cursor = Cursors.Default
                        word_server.ActiveDocument.Close(SaveChanges:=False)
                        word_server.Quit(False)
                        word_server = Nothing
                    ElseIf strArr(strArr.Length - 1) = "xlsx" Then
                        Dim excel_server As Microsoft.Office.Interop.Excel.Application
                        Application.DoEvents()
                    Me.Cursor = Cursors.WaitCursor
                    Try
                            excel_server = New Microsoft.Office.Interop.Excel.Application
                        Catch ex As Exception
                        Me.Cursor = Cursors.Default
                            MessageBox.Show("Error opening Excel.Basic" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                    End Try
                    Try
                            excel_server.Workbooks.Open(FileName:=CType(namefile, Object), ReadOnly:=True)
                        Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("Error opening file 1 " & namefile & vbCrLf & ex.Message)
                            Exit Sub
                        End Try
                    Try
                            excel_server.ActivePrinter = printer
                            If txtToPage.Text IsNot "" Then
                                excel_server.Worksheet.PrintOut(Copies:=Convert.ToInt32(txtNumberOfCopie.Text), Background:=False,
                                                                From:=txtFromPage.Text, [To]:=txtToPage.Text, ManualDuplexPrint:=both.Checked)
                            Else
                                excel_server.Worksheet.PrintOut(Copies:=Convert.ToInt32(txtNumberOfCopie.Text),
                        Background:=False, ManualDuplexPrint:=both.Checked)
                            End If
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("Error opening file 2 " & namefile & vbCrLf & ex.Message)
                            excel_server.Worksheet.Close(SaveChanges:=False)
                            Exit Sub
                        End Try
                    Me.Cursor = Cursors.Default
                        excel_server.Worksheet.Close(SaveChanges:=False)
                        excel_server = Nothing
                    End If
            Dim con As New MySqlConnection("server=localhost; user id = root ;password= ;database =printdatabase ;")
                    con.Open()
                    Dim com As String
                    com = "INSERT INTO t_file (file_name, printer_name) values ('" & file.ToString() & "','" & printer & "')"
                    Dim cmd As New MySqlCommand(com, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub selectAll_CheckedChanged(sender As Object, e As EventArgs) Handles selectAll.CheckedChanged
        Dim count As Int32 = listFiles.Items.Count
        If count > 0 Then
            For i = 0 To listFiles.Items.Count - 1 Step 1
                listFiles.SetItemChecked(i, selectAll.Checked)
            Next
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searcher As ManagementObjectSearcher
        searcher = New ManagementObjectSearcher("SELECT * FROM Win32_Printer")
        For Each printer As ManagementObject In searcher.Get
            Dim printename As String = Convert.ToString(printer.Item("Name"))
            Dim printerstatus As UInt16 = Convert.ToUInt16(printer.Item("PrinterStatus"))
            Dim printerAvailability As UInt16 = Convert.ToUInt16(printer.Item("Availability"))
            cbPrinter.Items.Add(printename)
        Next printer
    End Sub

    Private Sub cbPrinter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPrinter.SelectedIndexChanged
        printer = cbPrinter.SelectedItem
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs)
        Dim f1 As history = New history()
        f1.Show()
    End Sub
End Class

