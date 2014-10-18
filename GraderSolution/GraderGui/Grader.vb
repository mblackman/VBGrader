'-------------------------------------------------------------------------------------------------------------
' Name:        Chase Simmons, Ben VanSomeren, Matt Blackman, Jacob Noyes, Jacob Lange
' Date:        12/11/2012
' Last Edited: 03/12/2014
'-------------------------------------------------------------------------------------------------------------

Imports System.IO
Imports Microsoft.Win32

' Grader contains public methods to handle the grading of a single or multiple
' programs to be graded. The grading can be based off a single file or folder
' of executables, and in both cases the grader runs off a single grading script.
Public Class Grader

    ' Builds a program solution from a given directory and runs tests on that built solution.
    ' [buildFile] In - The location of the .sln or .vbproj
    ' [inFile] In - The grader input script
    ' [outFile] In - The output file for the grader
    Public Shared Sub BuildSingleSoltion(ByVal buildFile As String, ByVal inFile As String, ByVal outfile As String)

        Dim solutionDir As String = System.IO.Path.GetDirectoryName(buildFile)

        Dim buildOutput As String = BuildFromSln(buildFile)

        Dim buildDir As String = System.IO.Path.Combine(solutionDir, "bin\release")

        Dim executablesInBuildFolder = Directory.GetFiles(buildDir, "*.exe", SearchOption.TopDirectoryOnly)

        For Each File In executablesInBuildFolder
            If executablesInBuildFolder.Count = 1 Then
                GradeSingleExeFile(File.ToString, inFile, outfile)

            Else

                'Handle this
            End If
        Next

    End Sub

    ' Gets the compiler information from the computer and builds a program based on a sln file.
    ' [buildPath] In - Location of the .sln file.
    '
    ' Return: The output from the solution build
    Private Shared Function BuildFromSln(ByVal buildPath As String) As String

        Dim reg As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\MSBuild\\ToolsVersions\\4.0", False)

        Dim MSBuildExe As String = System.IO.Path.Combine(reg.GetValue("MSBuildToolsPath", 0) + "MSBuild.exe")

        Dim pProcess As System.Diagnostics.Process = New System.Diagnostics.Process()

        pProcess.StartInfo.FileName = MSBuildExe
        pProcess.StartInfo.Arguments = buildPath + " /t:clean;build /p:Configuration=Release"
        pProcess.StartInfo.UseShellExecute = False
        pProcess.StartInfo.RedirectStandardOutput = True

        pProcess.Start()

        Dim strOutput As String = pProcess.StandardOutput.ReadToEnd()

        pProcess.WaitForExit()

        Return strOutput

    End Function

    ' Grades multiple executables located in the same folder.
    ' [exeFolder] In - Folder with all the executable programs being graded.
    ' [inFile] In - The file used to determine how to grade program.
    ' [outFile] In - The file used to write output for grading of student.
    ' 
    ' Notes: The way outfile works might need to be changed to ensure it makes a seperate file for each student.
    Public Shared Sub GradeMultipleExeFiles(ByVal exeFolder As String, ByVal inFile As String, ByVal outFile As String)

        Dim exeFiles() As String = Directory.GetFiles(exeFolder, "*.exe")

        For Each path In exeFiles

            If Not path.Contains(".vshost") And Not path.Contains("VBGrader.exe") Then
                launchTester(path, inFile, outFile)

            End If
        Next

    End Sub

    ' Grades a single executable given by the user.
    ' [exePath] In - Path of the executable being graded.
    ' [inFile] In - The file used to determine how to grade program.
    ' [outFile] In - The file used to write output for grading of student.
    Public Shared Sub GradeSingleExeFile(ByVal exePath As String, ByVal inFile As String, ByVal outFile As String)

        launchTester(exePath, inFile, outFile)

    End Sub

    ' Launches the testing program for a given executable, input file, and output file. 
    ' This will throw exceptions if there is no given program or input.
    ' [exePath] In - Path of the executable being graded.
    ' [inputFile] In - The file used to determine how to grade program.
    ' [outputFile] In - The file used to write output for grading of student.
    Private Shared Sub launchTester(ByVal exePath As String, ByVal inputFile As String, ByVal outputFile As String)

        Dim testScript = New Script.Script(inputFile, outputFile, exePath)

        If exePath = "" Then
            Throw New Exception("No exe was specified.")

        End If

        If inputFile = "" Then
            Throw New Exception("No input file was selected.")

        End If

        Try
            testScript.runScript()

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try
    End Sub
End Class
