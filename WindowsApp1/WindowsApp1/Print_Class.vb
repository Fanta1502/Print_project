Imports System.Drawing.Printing
Public Class Print_Class
    Private myimage As Bitmap
    Private thectrl As Control

    Private Function Capturectrl(ByVal ctrl As Control) As Bitmap
        Dim memoryImage As Bitmap
        Dim memoryGraphics As Graphics
        memoryImage = Nothing
        Dim mygraphics As Graphics = ctrl.CreateGraphics()
        Dim s As Size = ctrl.Size
        If TypeOf ctrl Is Form AndAlso DirectCast(ctrl, Form).FormBorderStyle <> FormBorderStyle.None Then
            memoryImage = New Bitmap(s.Width - 10, s.Height - (SystemInformation.FrameBorderSize.Width + 6 + SystemInformation.CaptionHeight), mygraphics)
            memoryGraphics = Graphics.FromImage(memoryImage)
            memoryGraphics.CopyFromScreen(0, (SystemInformation.FrameBorderSize.Width + 0 + SystemInformation.CaptionHeight), 0, 0, New Size(memoryImage.Width, memoryImage.Height), CopyPixelOperation.SourceCopy)
        Else
            memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
            memoryGraphics = Graphics.FromImage(memoryImage)
            memoryGraphics.CopyFromScreen(ctrl.Left, ctrl.Top, 0, 0, New Size(memoryImage.Width, memoryImage.Height), CopyPixelOperation.SourceCopy)
        End If
        Return memoryImage
    End Function
    Public Function GetPreview() As Bitmap
        Return Capturectrl(thectrl)
    End Function
    Public Sub printdoc()
        Try
            Dim prtd As New PrintDialog

            'document à imprimer
            Dim doc As New PrintDocument
            myimage = Capturectrl(thectrl)
            AddHandler doc.PrintPage, AddressOf printform
            'paramètres de page
            Dim ps As New PageSettings
            ps.Landscape = False
            doc.DefaultPageSettings = ps
            'indique à la prévisualisation le document à montrer
            prtd.Document = doc
            If prtd.ShowDialog = DialogResult.OK Then
                prtd.Document.Print()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub printform(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Try
            e.Graphics.DrawImage(myimage, 0, 0)
            e.HasMorePages = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal ctrl As Control)
        thectrl = ctrl
    End Sub
End Class