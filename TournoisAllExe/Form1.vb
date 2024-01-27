Imports System.ComponentModel
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 1000
        Timer2.Start()
        tm = "00:05:00"

    End Sub

    Public tm As Date

    Public Sub EXE(rs As Integer)
        Dim FileName As String
        Dim BytesToWrite() As Byte
        If rs = 1 Then
            FileName = IO.Path.Combine(Application.StartupPath, "TimerAlbinton.exe")
            BytesToWrite = My.Resources.TimerAlbinton
        ElseIf rs = 2 Then
            FileName = IO.Path.Combine(Application.StartupPath, "TournoiAllAuto.xlsm")
            BytesToWrite = My.Resources.TournoiAllAuto
        ElseIf rs = 3 Then
            FileName = IO.Path.Combine(Application.StartupPath, "TournoiAllAuto.pptm")
            BytesToWrite = My.Resources.TournoiAllAutoPPT
            'ElseIf rs = 4 Then
            '    FileName = IO.Path.Combine(Application.StartupPath, "FEUILLE DE MARQUE.xlsm")
            '    BytesToWrite = My.Resources.FEUILLE_DE_MARQUE
        End If

        Dim FileStream As New System.IO.FileStream(FileName, System.IO.FileMode.OpenOrCreate)
        Dim BinaryWriter As New System.IO.BinaryWriter(FileStream)
        BinaryWriter.Write(BytesToWrite)
        BinaryWriter.Close()
        FileStream.Close()
        Process.Start(FileName)
    End Sub

    Private Sub bexecuter_Click(sender As Object, e As EventArgs) Handles bexecuter.Click

        tm = TextBox1.Text
        Timer1.Interval = 1000
        Timer1.Start()
        For a = 1 To 3 '4
            Try
                EXE(a)
            Catch
            End Try
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i = FolderBrowserDialog1.ShowDialog
        If i = DialogResult.OK Then
            ListBox1.Items.Add(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' intervalsave += 1

        tm = tm.AddSeconds(-1)
        LS.Text = tm
        If tm = "00:00:00" Then

            For Each item In ListBox1.Items
                File.Copy(".\TournoiAllAuto.xlsm", item & "\TournoiAllAuto " & Format(Now, "yyyy MM dd HH mm ss") & ".xlsm")
            Next
            tm = TextBox1.Text
            'MsgBox("ok")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LH.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Try
        '    File.Delete(".\TimerAlbinton.exe")
        '    File.Delete(".\TournoiAllAuto.xlsm")
        '    File.Delete(".\TournoiAllAuto.pptm")
        '    File.Delete(".\FEUILLE DE MARQUE.xlsm")
        'Catch
        'End Try
    End Sub
End Class
