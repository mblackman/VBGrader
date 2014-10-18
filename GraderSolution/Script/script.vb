'-------------------------------------------------------------------------------------------------------------
' Name:        Chase Simmons, Ben VanSomeren, Matt Blackman, Jacob Noyes, Jacob Lange
' Date:        12/11/2012
' Last Edited: 03/12/2014
'-------------------------------------------------------------------------------------------------------------

Imports System.IO
Imports System.Text.RegularExpressions

' Script reads in a script file, applies it to a running application, and prints out a report file 
' containing all of the error that occured in the script.
' Notes: Look in to getting rid of totalTests += 1 in most functions
'        Rework click methods
'        Fix expect sub to handle errors
'        Add error handling to getDataGridCell
'        Seperate the command functions into a seperate class and clean up class variables
Public Class Script

    Private scriptFile As List(Of String)                           'List of all lines in the script which will be used.

    Private scriptCommander As ScriptCommands

    Private _executablePath As String
    Private _filePath As String                                  'Path of all files.
    Private _outputPath As String                                'Path of output file (.out)
    Private _fileHeader As String

    Private loadedProperty As String                             'The property to check.
    Private currentForm As String                                'Currently loaded form

    Private inFind As Boolean
    Private inProp As Boolean

    'Sets the output file main header line.
    Public Property FileHeader As String

        Get
            Return _fileHeader

        End Get

        Set(ByVal value As String)
            _fileHeader = "Main Form Title: " & value & vbCrLf

        End Set
    End Property

    ' Property for the input script location. Controls the _filePath private variable
    Public Property Input As String

        Get
            Return _filePath

        End Get

        Set(ByVal value As String)

            _filePath = value

        End Set
    End Property

    ' Allow for the user to get and set the file path of where the error log should be created.
    Public Property Output As String

        Get
            Return _outputPath

        End Get

        Set(ByVal value As String)

            _outputPath = value

        End Set
    End Property

    ' Constructor for script when no parameters are sent in.
    ' Initalizes and loads the script file.
    Public Sub New()

        scriptFile = New List(Of String)

        inFind = False
        inProp = False

        loadFile()

    End Sub

    ' Constructor for Script, which takes in a filePath defined by the user as the 
    ' storate location of the script to be read in.
    ' [inputFile] In - Path to the input file of the script.
    ' [outputFile] In - Path to the output file of the script.
    Public Sub New(ByVal inputFile As String, ByVal outputFile As String, ByVal exePath As String)

        scriptFile = New List(Of String)
        _executablePath = exePath
        Input = inputFile
        Output = outputFile

        loadFile()

    End Sub

    ' Takes in a single line of the script file and converts the whole string into a list
    ' of commands to be sent in to the script tester. 
    ' [params] In/Out - A single string of the script command line to be parsed.
    '
    ' Return: Returns the converted string array of the script command.
    Private Function convertArgs(ByVal params As String) As String()

        Dim returnArgs As List(Of String) = New List(Of String)

        Dim inQuotesOrWordRegex As Regex = New Regex("""[^""]*""|(\w|\S)+")
        Dim inQuotesRegex As Regex = New Regex("""[^""]*""")
        Dim replaceQuotesRegex As Regex = New Regex("(^"")|(""$)")

        Dim args As MatchCollection = inQuotesOrWordRegex.Matches(params)

        For Each arg As Match In args
            If inQuotesRegex.IsMatch(arg.ToString) Then
                returnArgs.Add(replaceQuotesRegex.Replace(arg.ToString, ""))

            Else
                returnArgs.Add(arg.ToString)

            End If
        Next

        Return returnArgs.ToArray

    End Function

    ' Copies a file to a location which the sub creates depending on the target's name.
    ' [base] In - The file to be copied.
    ' [targert] In - The location where you will save the copy.
    Private Sub copyFile(ByVal base As String, ByVal target As String)

        Directory.CreateDirectory(target.Substring(0, target.LastIndexOf("\")))
        FileCopy(base, target)

    End Sub

    ' Writes out the end footer of the script to the script file and prints out information to 
    ' the Console console.
    '
    ' The script footer appears as:
    '   "---------- 7 Points out of 10 Points ---------
    '    ---------- 6 Errors  out of 24 Tests ---------"
    Private Sub endScript()

        Dim errorList = scriptCommander.getErrorList()
        Dim totalScore = scriptCommander.getTotalScore()
        Dim finalScore = scriptCommander.getMaximumScore()
        Dim totalTests = scriptCommander.getTotalTests()

        errorList.Insert(0, vbCrLf)
        errorList.Insert(0, "---------- " & errorList.Count - 1 & " Errors out of " & totalTests & " Tests ----------" & vbCrLf)
        errorList.Insert(0, "---------- " & totalScore & " Points out of " & finalScore & " Points ---------" & vbCrLf)

        writeLogFile()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Finished Test successfully!")
        Console.WriteLine("Score: " & totalScore & " out of " & finalScore)
        Console.WriteLine("---------- " & errorList.Count & " Errors  out of " & totalTests & " Tests----------")

        For i As Integer = 0 To errorList.Count - 1
            Console.Write(errorList.ElementAt(i))

        Next

        If errorList.Count = 0 Then
            Console.WriteLine("There were no errors.")

        End If
        Console.WriteLine("")
        Console.WriteLine("")

    End Sub

    ' Based off the filepath given by the user for the scripts input file, this loads that input script
    ' into a container, which can be more easily read and manipulated across the entire program.
    '
    ' Notes: The variables being used in this sub are all class scoped variables.
    Private Sub loadFile()

        Dim reader = New StreamReader(_filePath)
        Dim line = ""

        Try
            While Not reader.Peek = Nothing
                ' read in blank lines
                While line.Trim = ""
                    line = reader.ReadLine

                End While

                If Not line.Trim.Substring(0, 1) = "'" Then
                    scriptFile.Add(line)

                End If

                line = reader.ReadLine

            End While

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try

        reader.Close()

    End Sub

    ' A a pre-parsed strings is sent in, and depending on the first arguments in that list, the program will
    ' call other methods within the script class file to perform specific operations on the program being graded.
    ' [args] In - A list of arguments which define what operation will take place. The first argument will always
    '             be the command, with the following arguments being the arguments to send into other methods.
    Private Sub runCommand(ByRef args As String())

        Select Case args(0).ToLower
            Case "aligned"
                scriptCommander.checkAligned(args(1), args(2), args(3), args(4))

            Case "checkcombobox"
                scriptCommander.checkComboBox(args(1), args(2), args(3), args(4))

            Case "checklistbox"
                scriptCommander.checkListBox(args(1), args(2), args(3), args(4))

            Case "contains"
                scriptCommander.contains(args(1), args(2), args(3), args(4))

            Case "click"
                scriptCommander.click(args(1))

            Case "clickbindingnavigator"
                scriptCommander.clickBindingNavigator(args(1))

            Case "closedatabase"
                scriptCommander.closeDatabase(args(1))

            Case "copy"
                copyFile(args(1), args(2))

            Case "end"
                If args(1).ToLower = "find" Then
                    inFind = False

                ElseIf args(1).ToLower = "prop" Then
                    inProp = False

                Else
                    Console.WriteLine("Unknown command: " & args(1))

                End If

            Case "expect"
                scriptCommander.expect(args(1), args(2), args(3), args(4))

            Case "find"
                inFind = True

            Case "loaddatabase"
                scriptCommander.loadDatabase(args(1), args(2))

            Case "printtable"
                scriptCommander.printTable(args(1))

            Case "prop"
                loadedProperty = args(1)
                inProp = True

            Case "opendatabase"
                scriptCommander.openDatabase(args(1))

            Case "sendkey"
                scriptCommander.sendKey(args(1), args(2))

            Case "setdatagridcell"
                scriptCommander.setDataGridCell(args(1), args(2), args(3))

            Case "setfocus"
                scriptCommander.setFocus(args(1))

            Case "setform"
                scriptCommander.setForm(args(1))
                currentForm = args(1)

            Case "setformprop"
                scriptCommander.setFormProperty(args(1), args(2), args(3))

            Case "setlistboxindex"
                scriptCommander.setListBoxIndex(args(1), args(2))

            Case "setproperty"
                scriptCommander.setProperty(args(1), args(2), args(3))

                'Case "settablevalue"
                '    scriptCommander.setTableValue(args(1), args(2), args(3), args(4), args(5))

            Case "totalpoints"
                scriptCommander.setTotalPoints(args(1))

            Case "query"
                scriptCommander.query(args(1), args(2), args(3))

            Case "taborder"
                scriptCommander.checkTabOrder(args)

            Case Else
                If inFind Then
                    For i As Integer = 1 To args.Length - 1
                        scriptCommander.find(args(0), args(i))

                    Next

                ElseIf inProp Then
                    scriptCommander.check(loadedProperty, args(0), args(1), args(2))

                Else
                    Console.WriteLine("Command not reconized: " & String.Join(" ", args.ToArray()))

                End If
        End Select
    End Sub

    ' Reads through the script file designated by the user, and parses each line into a list of command arguments
    ' to be sent into the runCommand() sub, and have that command tested on the program.
    ' An active tally is kept on how many commands have been run.
    ' If any exceptions are thrown during a command, a error message is printed to the Console output and an error count
    ' is updated.
    Private Sub runRoutines()

        Dim errorcount As Integer = 0
        Dim args As String()

        For Each scriptLine As String In scriptFile
            Try
                args = convertArgs(scriptLine)
                runCommand(args)

            Catch ex As Exception
                Console.WriteLine("-----------------------------------------------------------")
                Console.WriteLine("Error on line: """ & String.Join(" ", args) & """.")
                Console.WriteLine(ex.Message)
                Console.WriteLine("-----------------------------------------------------------")
                errorcount += 1

            End Try

            If scriptCommander.Running = False Then
                Exit For
            End If
        Next

        Console.WriteLine("")

    End Sub

    ' A public function for other classes to call in order to invoke the grading once all the parameters for the grader running.
    ' are properly set up.
    '
    ' Notes: See if we can go without this public function.
    Public Sub runScript()

        scriptCommander = New ScriptCommands(_executablePath)

        runRoutines()

        scriptCommander.closeAssembly()

        endScript()

    End Sub

    ' Writes all the grading errors into the output file.
    ' The output file path is defined by the user, and if the file already exists, a new file is created.
    ' This sub handles both opening and closing the file.
    '
    ' Notes: Clean up the deleting of old files if possible.
    Private Sub writeLogFile()

        Dim errorList = scriptCommander.getErrorList()
        Dim objWriter As New System.IO.StreamWriter(_outputPath)

        If System.IO.File.Exists(_outputPath) <> True Then
            Dim FSO As Object = CreateObject("Scripting.FileSystemObject")
            Dim newFile As Object = FSO.CreateTextFile(_outputPath, True, False)

        End If

        objWriter.Write(FileHeader)

        For i = 0 To errorList.Count - 1
            objWriter.Write(errorList(i))

        Next

        objWriter.Close()

    End Sub
End Class