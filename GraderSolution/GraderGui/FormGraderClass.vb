'-------------------------------------------------------------------------------------------------------------
' Name:        Chase Simmons, Ben VanSomeren, Matt Blackman, Jacob Noyes, Jacob Lange
' Date:        12/11/2012
' Last Edited: 03/12/2014
'-------------------------------------------------------------------------------------------------------------

Imports System

' The main GUI of the VBGrader, which allows the user to select the files and folders of programs
' to be graded.
' This has all the controls and output areas to successfully grade a program designated by a user, given
' they have a program to grade an script to use.
Public Class FormGraderClass

    Public Property ExeFile As String
    Public Property InputFile As String
    Public Property OutputFile As String
    Public Property Folder As String

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Application.ExitThread()
        Application.Exit()

    End Sub

    <STAThread()> _
    Public Shared Sub Main()

        Application.Run(New FormGraderClass)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Grader.GradeSingleExeFile(ExeFile, InputFile, OutputFile)
            txtOutput.Text = System.IO.File.ReadAllText(OutputFile)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        Dim fileFolder As New OpenFileDialog
        Dim theFolder As New FolderBrowserDialog

        If rdoFile.Checked Then
            If fileFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFileFolder.Text = fileFolder.FileName
                ExeFile = fileFolder.FileName

            End If
        Else
            If theFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFileFolder.Text = theFolder.SelectedPath
                Folder = theFolder.SelectedPath

            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

        Dim fileFolder As New OpenFileDialog

        fileFolder.Filter = "in|*.in|All|*.*"

        If fileFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtInputFile.Text = fileFolder.FileName
            InputFile = fileFolder.FileName
            OutputFile = InputFile.Substring(0, InputFile.LastIndexOf(".") + 1) & "out"
            'txtFileFolder.Text = OutputFile

        End If
    End Sub

    Public Sub ShowOutFile()

        txtOutput.Text = System.IO.File.ReadAllText(OutputFile)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Try
            Grader.GradeMultipleExeFiles(Folder, InputFile, OutputFile)
            txtOutput.Text = System.IO.File.ReadAllText(OutputFile)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

   Private Sub FormGraderClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim fileFolder As New OpenFileDialog
        fileFolder.Filter = "sln|*.sln|All|*.*"

        Dim buildSolution As String = ""

        If fileFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            buildSolution = fileFolder.FileName

        End If

        Try

            Grader.BuildSingleSoltion(buildSolution, InputFile, OutputFile)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

   End Sub
End Class