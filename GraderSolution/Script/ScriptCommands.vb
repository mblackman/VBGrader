'-------------------------------------------------------------------------------------------------------------
' Name:        Chase Simmons, Ben VanSomeren, Matt Blackman, Jacob Noyes, Jacob Lange
' Date:        12/11/2012
' Last Edited: 03/12/2014
'-------------------------------------------------------------------------------------------------------------

Imports System.Reflection
Imports System.Threading
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports UWPCS3340.AssemblyImage

' ScriptCommands contains the methods to be used by the script to perform functions 
' across the user loaded form. 
' This creates an assembly which controls the Windows Forms through reflection
' and uses the assembly's methods and functionality to manipulate script
' commands to test the user's program.
Public Class ScriptCommands

    Private testAssembly As UWPCS3340.AssemblyImage                     ' The assembly used to access the loaded user form.

    Private databases As New Dictionary(Of String, OleDbConnection)     'Stores database connectsion.
    Private tables As New Dictionary(Of String, System.Data.DataTable)  'Stores datatables.

    Private errorList As New List(Of String)                            'List of errors.
    Private results As New List(Of String)                              'Holds output before it is printed out.

    Private totalTests As Integer                                       'Count of lines of tests ran.
    Private finalScore As Single = 0.0                                  'Score achieved by student.
    Private totalScore As Single = 0.0                                  'Max score possible.

    Private mainFormLoaded As Boolean = False                           'Let's the program know if the main form has been loaded

    Public Running As Boolean

    ' Default sub to intialize and load the class.
    Public Sub New(ByVal exePath As String)

        testAssembly = New UWPCS3340.AssemblyImage(exePath)
        results = New List(Of String)
        errorList = New List(Of String)

        Running = True

        totalTests = 0

    End Sub

    ' Checks the value of the specified component against an expected value.
    ' [componentName] In - Name of the form component to be checked.
    ' [propertyName] In - Name of the property in the component given by the user.
    ' [expectedValue] In - What the component's property should match.
    ' [scoreAmount] In - How much an incorrect answer is worth.
    Public Sub check(ByVal componentName As String, ByVal propertyName As String, ByVal expectedValue As String, ByVal scoreAmount As String)

        If propertyName.ToLower = "centered" Then
            checkCentered(componentName, expectedValue, scoreAmount)

        Else
            Dim temp As String = testAssembly.GetProperty(componentName, propertyName).ToString

            Console.Write("")
            Console.WriteLine(totalTests & " " & componentName & " +++++++ Got: " & temp & " ----- wanted: " & expectedValue)

            If Not temp = expectedValue Then
                Dim tempString As String = "Error in Component: " & componentName & vbCrLf _
                               & "                 Property: " & propertyName & vbCrLf _
                               & "               Expected: " & expectedValue & vbCrLf _
                               & "              But Found: " & temp.ToString & vbCrLf & vbCrLf
                errorList.Add(tempString)
                totalScore -= scoreAmount

            End If

            totalTests += 1

        End If
    End Sub

    ' Checks to see if two components are aligned to top, left or center. 
    ' [alignPos] In - The face of the walls you are checking if aligned. (left, right, top, bottom, center)
    ' [ctrl1] In - The value of the position of the first objects side.
    ' [ctrl2] In - The value of the position of the second objects side.
    ' [scoreAmount] In - How much an incorrect answer is worth.
    '
    ' Notes: No error handling.
    Public Sub checkAligned(ByVal alignPos As String, ByVal ctrl1 As String, ByVal ctrl2 As String, ByVal scoreAmount As String)

        If alignPos.ToLower.Contains("left") Then
            Dim ctrl1X = testAssembly.GetProperty(ctrl1, "Left")
            Dim ctrl2X = testAssembly.GetProperty(ctrl2, "Left")

            If ctrl1X <> ctrl2X Then
                Dim tempString As String = "Error in Component: " & ctrl1 & " " & ctrl2 & vbCrLf _
                           & "                 Property: Aligned " & alignPos & vbCrLf _
                           & "               Expected: " & ctrl1 & " Left = " & ctrl1X & vbCrLf _
                           & "              But Found: " & ctrl2 & " Left = " & ctrl2X & vbCrLf & vbCrLf

                errorList.Add(tempString)
                totalScore -= scoreAmount

            End If

        ElseIf alignPos.ToLower.Contains("top") Then
            Dim ctrl1Y = testAssembly.GetProperty(ctrl1, "Top")
            Dim ctrl2Y = testAssembly.GetProperty(ctrl1, "Top")

            If ctrl1Y <> ctrl2Y Then
                Dim tempString As String = "Error in Component: " & ctrl1 & " " & ctrl2 & vbCrLf _
                           & "                 Property: Aligned " & alignPos & vbCrLf _
                           & "               Expected: " & ctrl1 & " Top = " & ctrl1Y & vbCrLf _
                           & "              But Found: " & ctrl2 & " Top = " & ctrl2Y & vbCrLf & vbCrLf

                errorList.Add(tempString)
                totalScore -= scoreAmount

            End If

        Else
            Dim ctrl1X = testAssembly.GetProperty(ctrl1, "Left")
            Dim ctrl2X = testAssembly.GetProperty(ctrl2, "Left")
            Dim ctrl1Width = testAssembly.GetProperty(ctrl1, "Width")
            Dim ctrl2Width = testAssembly.GetProperty(ctrl2, "Width")

            Dim ctrl1Center As String = (ctrl1X + (ctrl1Width / 2)).ToString()
            Dim ctrl2Center As String = (ctrl2X + (ctrl2Width / 2)).ToString()

            If ctrl1Center <> ctrl2Center Then
                Dim tempString As String = "Error in Component: " & ctrl1 & " " & ctrl2 & vbCrLf _
                           & "                 Property: Aligned " & alignPos & vbCrLf _
                           & "               Expected: " & ctrl1 & " Center = " & ctrl1Center & vbCrLf _
                           & "              But Found: " & ctrl2 & " Center = " & ctrl2Center & vbCrLf & vbCrLf

                errorList.Add(tempString)
                totalScore -= scoreAmount

            End If
        End If

        totalTests += 1

    End Sub

    ' Checks to see if a component is centered either horizontally or vertically on the form. 
    ' [formName] In - Name of the form you want to look at.
    ' [controlName] In - Name of the compenent on the main form you want.
    ' [center] - Indicated if what centered orientation you want. (horizontal/vertical)
    ' [scoreAmount] In - How much an incorrect answer is worth.
    '
    ' Notes: Still a little buggy.
    Public Sub checkCentered(ByVal controlName As String, ByVal center As String, ByVal scoreAmount As String)

        Dim formCenter = 0
        Dim componentCenter = 0
        Dim componentSize = 0
        Dim formName As String = testAssembly.getCurrentForm().Name


        If center.ToLower.Contains("horizontal") Then
            formCenter = testAssembly.GetProperty(formName, "Width")
            componentCenter = testAssembly.GetProperty(controlName, "Left")
            componentSize = testAssembly.GetProperty(controlName, "Width") + 10

        ElseIf center.ToLower.Contains("vertical") Then
            formCenter = testAssembly.GetProperty(formName, "Height")
            componentCenter = testAssembly.GetProperty(controlName, "Top")
            componentSize = testAssembly.GetProperty(controlName, "Height") + 32

        End If

        formCenter = formCenter / 2
        componentCenter += componentSize / 2

        Console.WriteLine(totalTests & " " & controlName & " +++++++ Got: " & componentCenter & " ----- wanted: " & formCenter - 1 & "-" & formCenter + 1)

        If Not (componentCenter - 2 <= formCenter And componentCenter + 2 >= formCenter) Then
            Dim tempString As String = "Error in Component: " & controlName & vbCrLf _
                           & "                 Property: " & center & vbCrLf _
                           & "               Expected: " & formCenter & vbCrLf _
                           & "              But Found: " & componentCenter & vbCrLf & vbCrLf

            errorList.Add(tempString)
            totalScore -= scoreAmount

        End If

        totalTests += 1

    End Sub

    ' Checks the value of the specified component against an expected value for a ComboBox(they aren't the same as a regular control).
    ' [componentName] In - Name of the form component to be checked.
    ' [propertyName] In - Name of the property in the component given by the user.
    ' [expectedValue] In - What the component's property should match.
    ' [scoreAmount] In - How much an incorrect answer is worth.
    Public Sub checkComboBox(ByVal componentName As String, ByVal propertyName As String, ByVal expectedValue As String, ByVal scoreAmount As Integer)

        Dim temp As String = testAssembly.getComboBoxValue(componentName, propertyName).Trim

        If Not temp = expectedValue Then
            Dim tempString As String = "Error in Component: " & componentName & vbCrLf _
                           & "          Property: ListBox.Items(" & propertyName & ").Text" & vbCrLf _
                           & "          Expected: " & expectedValue & vbCrLf _
                           & "         But Found: " & temp & vbCrLf
            errorList.Add(tempString)
            totalScore -= scoreAmount

        End If

        totalTests += 1

    End Sub

    ' Checks the value of the specified component against an expected value for a ListBox(they aren't the same as a regular control).
    ' [componentName] In - Name of the form component to be checked.
    ' [propertyName] In - Name of the property in the component given by the user.
    ' [expectedValue] In - What the component's property should match.
    ' [scoreAmount] In - How much an incorrect answer is worth.
    Public Sub checkListBox(ByVal componentName As String, ByVal propertyName As String, ByVal expectedValue As String, ByVal scoreAmount As Integer)

        Dim tempobj As ListBox = testAssembly.getListbox(componentName)

        Console.Write("")
        Dim temp As String = ""

        Try
            Dim tempInt As Integer = Integer.Parse(propertyName)
            temp = tempobj.Items(tempInt).ToString

        Catch ex As Exception

        End Try

        Console.WriteLine(totalTests & " " & componentName & " +++++++ Got: " & temp & " ----- wanted: " & expectedValue)

        If Not temp = expectedValue Then
            Dim tempString As String = "Error in Component: " & componentName & vbCrLf _
                           & "          Property: " & propertyName & vbCrLf _
                           & "          Expected: " & expectedValue & vbCrLf _
                           & "         But Found: " & temp.ToString & vbCrLf
            errorList.Add(tempString)
            totalScore -= scoreAmount

        End If

        totalTests += 1

    End Sub

    ' Checks the order of tabs on a form to see if they match a specified order. If the order is incorrect
    ' a message is printed to the output. 
    ' [args] In - An array of strings which contain the tabs on the current form.
    '
    ' Notes: Make sure this works correctly.
    Public Sub checkTabOrder(ByVal args As String())

        Dim componentName As String
        Dim scoreAmount As Single = args(args.Length - 1)

        For index = 1 To args.Length - 2
            componentName = args(index)
            testAssembly.GetActiveControl()

            If testAssembly.ActiveControl = componentName Then
                SendKeys.Send("{TAB}")
                'Thread.Sleep(5)

            Else
                Dim tempString As String = "Incorrect Tab Order: " & componentName & vbCrLf & vbCrLf
                errorList.Add(tempString)
                totalScore -= scoreAmount

                Exit Sub

            End If
        Next

        componentName = args(1)
        testAssembly.GetActiveControl()

        If Not testAssembly.ActiveControl = componentName Then
            Dim tempString As String = "Incorrect Tab Order: " & componentName & vbCrLf & vbCrLf
            errorList.Add(tempString)
            totalScore -= scoreAmount

        End If
    End Sub

    ' Clicks a given button on the targeted form.
    ' [componentName] In - Name of the form component to be checked.
    Public Sub click(ByVal componentName As String)

        Dim temp As Form = testAssembly.getCurrentForm()

        If Not IsNothing(temp) Then
            Dim p() As Object = {Nothing, New EventArgs()}
            testAssembly.InvokeMethod(temp, componentName & "_Click", p)

        End If
    End Sub

    ' Clicks a button on a BindingNavigator.
    ' [buttonName] In - Name of the button to be clicked.
    Public Sub clickBindingNavigator(ByVal buttonName As String)

        testAssembly.clickBindingNavigator(buttonName)

    End Sub

    ' This function is used to call the function inside the test assembly to close down
    ' all the forms and stop the running threads.
    Public Sub closeAssembly()

        testAssembly.stopAssembly()

    End Sub

    ' Closes the given database connection if it exists.
    ' [databaseName] In - Name of the database to be closed.
    Public Sub closeDatabase(ByVal databaseName As String)

        If databases.ContainsKey(databaseName) Then
            databases(databaseName).Close()

        Else
            Throw New Exception("Database:" & databaseName & " was not found and could not be closed.")

        End If
    End Sub

    ' Checks to see if the name property of a component contains a specified string.
    ' [componentName] In - Name of the form component to be checked.
    ' [propertyName] In - Name of the property in the component given by the user.
    ' [expectedValue] In - What the component's property should match.
    ' [scoreAmount] In - How much an incorrect answer is worth.
    Public Sub contains(ByVal componentName As String, ByVal propertyName As String, ByVal expectedValue As String, ByVal scoreAmount As Integer)

        Dim temp As String = testAssembly.GetProperty(componentName, propertyName).ToString

        Console.WriteLine(totalTests & " +++++++ Got: " & temp & " ----- wanted: " & expectedValue)

        If Not temp.ToLower.Contains(expectedValue.ToLower) Then
            Dim tempString As String = "Error in Component: " & componentName & vbCrLf _
                         & "          Property: " & propertyName & vbCrLf _
                         & "    Should Contain: " & expectedValue & vbCrLf _
                         & "         But Found: " & temp.ToString & vbCrLf
            errorList.Add(tempString)
            totalScore -= scoreAmount

        End If

        totalTests += 1

    End Sub

    ' Decides if a value is the same, different, less than, greater than, or within a certain range of the expected value.
    ' [variable] In - A variable the user is looking for on the windows form.
    ' [comparitor] In - A mathematical comparitor which can be <> (not equals), = (equals), > (less than), > (greater than),
    '                   close (A close approximation by a factor of +- 5).
    ' [literal] In - The literal value the variable value will be compared against.
    ' [scoreAmount] In - How much an incorrect answer is worth.
    '
    ' Notes: This function doesn't handle any sort of error detection, which is a must add.
    '        Make sure this works after 5/8/14 update
    Public Sub expect(ByVal variable As String, ByVal comparitor As String, ByVal literal As String, ByVal scoreAmount As Single)

        Dim value As String = testAssembly.getValue(variable)

        If comparitor.Trim = "<>" Then
            If value = literal Then
                errorList.Add("Error in variable: " & variable & vbCrLf & _
                               "          Expected: " & literal & vbCrLf & _
                               "         But Found: " & value & vbCrLf & vbCrLf)
                totalScore -= scoreAmount

            End If

        ElseIf comparitor.Trim = "=" Then
            If value <> literal Then
                errorList.Add("Error in variable: " & variable & vbCrLf & _
                               "          Expected: " & literal & vbCrLf & _
                               "         But Found: " & value & vbCrLf & vbCrLf)
                totalScore -= scoreAmount

            End If

        ElseIf comparitor.Trim = ">" Then
            If Integer.Parse(value) <= Integer.Parse(literal) Then
                errorList.Add("Error in variable: " & variable & vbCrLf & _
                               "          Expected: > " & literal & vbCrLf & _
                               "         But Found: " & value & vbCrLf & vbCrLf)
                totalScore -= scoreAmount

            End If

        ElseIf comparitor.Trim = "<" Then
            If Integer.Parse(value) >= Integer.Parse(literal) Then
                errorList.Add("Error in variable: " & variable & vbCrLf & _
                                "          Expected: < " & literal & vbCrLf & _
                                "         But Found: " & value & vbCrLf & vbCrLf)
                totalScore -= scoreAmount

            End If

        ElseIf comparitor.Trim = "close" Then
            If value < literal - 5 Or value > literal + 5 Then
                errorList.Add("Error in variable: " & variable & vbCrLf & _
                                "          Expected: Within 5 of " & literal & vbCrLf & _
                                "         But Found: " & value & vbCrLf & vbCrLf)
                totalScore -= scoreAmount

            End If

        End If

        Console.WriteLine(totalTests & " " & "EXPECT" & " +++++++ Got: " & value & " ----- wanted: " & comparitor & " " & literal)
        totalTests += 1

    End Sub

    'Finds the specified component given the x and y coordinates. The x and y coordinate system works like this:
    'controls of the same type are given x and y values based on their position on the screen.
    ' [controlType] In - The type of Windows Form Control you are searching for.
    ' [controlName] In - The literal name of the Windows Form Control on the current Windows Form.
    Public Sub find(ByVal controlType As String, ByVal controlName As String)

        Dim controlExists As Boolean = False

        If controlType.ToUpper.Equals("ToolStripMenuItem".ToUpper) Then
            controlExists = testAssembly.findToolStripItem(controlName)

        ElseIf controlType.ToUpper.Equals("FORM") Then
            controlExists = loadForm(controlName)

        Else
            controlExists = testAssembly.findFormControl(controlName, controlType)

        End If

        If Not controlExists Then

            Dim errorMessage As String = "Component: " & controlName & " of type " & controlType & " could not be found"

            stopScriptExecution(errorMessage)

        End If
    End Sub

    ' Gets the error list of incorrect objects on the graded program.
    '
    ' Return: Returns the list of errors.
    Public Function getErrorList() As List(Of String)

        Return errorList

    End Function

    ' Returns the maximum amount of points a program can recieve.
    ' 
    ' Return: The max score a program can get.
    Public Function getMaximumScore() As Integer

        Return finalScore

    End Function

    ' Gets the total score the user had on the program after grading.
    '
    ' Return: The score the user got on the program.
    Public Function getTotalScore() As Integer

        Return totalScore

    End Function

    ' Returns the total number of tests run against the graded program.
    '
    ' Return: The total number of tests run on the program.
    Public Function getTotalTests() As Integer

        Return totalTests

    End Function

    ' Loads a database from the user's program into the VBGrader to allow the program to access the Database.
    ' If the Database is already present, it will remove the database and re-add it. 
    ' [name] In - The name of the Database being searched for.
    ' [filePath] In - The location of the Database in the computers storage.
    '
    ' Notes: Why do we open and close the connection?
    Public Sub loadDatabase(ByVal name As String, ByVal filePath As String)

        Try
            Dim temp As String() = filePath.Split("\")
            Dim connection As OleDb.OleDbConnection = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=" & filePath)

            connection.Open()
            connection.Close()

            If databases.ContainsKey(name) Then
                databases.Remove(name)

            End If

            databases.Add(name, connection)

        Catch ex As Exception
            Console.WriteLine("Could not open database.")

        End Try

    End Sub

    ' Loads the specified form based upon the parameters located in list of strings sent into the sub.
    ' Used to load other forms in the program once the main form has already been loaded with loadMainForm().
    ' [args] In - A list of arguments which explain the name of the form and what controls will be found on it.
    '             This must be a container with no defined size, because we cannot predict the number of arguments.
    '             The usual format for aguments would appear as followed:
    '             (Name of form, controlType 1, controlType 2, ..., controlType N - 1)
    Public Function loadForm(ByVal formName As String) As Boolean

        Dim foundForm As Boolean = False

        If Not mainFormLoaded Then

            foundForm = testAssembly.testProgram(formName)
            mainFormLoaded = True

        Else

            foundForm = testAssembly.setCurrentForm(formName)

        End If

        Return foundForm

    End Function

    ' Opens the database connection for a database defined by the user.
    ' [name] In - Name of the database as it appears in the program.
    Public Sub openDatabase(ByVal name As String)

        If databases.ContainsKey(name) Then
            databases(name).Open()
            databases(name).ResetState()

        Else
            Throw New Exception("Database:" & name & " was not loaded.")

        End If
    End Sub

    ' Prints out all of the values in a table, which are seperated by " | ".
    ' [tableName] In - Name of the table being looked for on the Windows Form.
    Public Sub printTable(ByVal tableName As String)

        If tables.ContainsKey(tableName) Then
            Console.WriteLine("--------------PRINTING TABLE-------------")
            Dim temp As System.Data.DataTable = tables(tableName)

            For i As Integer = 0 To temp.Rows.Count - 1
                For j As Integer = 0 To temp.Columns.Count - 1
                    Console.Write((temp(i)(j)).ToString)
                    Console.Write(" | ")

                Next

                Console.WriteLine("")

            Next

        End If
    End Sub

    ' Searches for a Database which has been loaded previously by the user in the scripts, and
    ' runs a query sent in to this sub, and stores the results of that query in a new table on
    ' the Database, whose name has been defined by the user.
    ' [dbase] In - The name of the Database, which should have already been loaded.
    ' [name] In - The name of the table, which will be created to store the query results.
    ' [query] In -  A database query the user wants to get.
    Public Sub query(ByVal dbase As String, ByVal name As String, ByVal query As String)

        If Not databases.ContainsKey(dbase) Then
            Throw New Exception("Database:" & dbase & " was not loaded or defined.")

        End If

        If tables.ContainsKey(name) Then
            tables.Remove(name)

        End If

        Dim command As New OleDbCommand(query, databases(dbase))

        Using myDataReader As OleDbDataReader = command.ExecuteReader()
            If myDataReader.Read() Then
                Dim da As New OleDb.OleDbDataAdapter
                Dim ds As New DataSet
                Dim dt As New System.Data.DataTable

                da.SelectCommand = New OleDb.OleDbCommand(query, databases(dbase))
                da.Fill(ds, "Table")
                dt = ds.Tables("Table")

                tables.Add(name, dt)

            End If
        End Using
    End Sub

    ' Sends input to the currently focused Windows form in the program being graded, which acts as
    ' a virtual key-press that the form recieves. Only works with a single key-press.
    ' [componentName] In - Name of the Windows Form Control which will recieve the keypress.
    '                      Can be the main form of components of it.
    ' [keyPress] In - The key command being sent in.
    Public Sub sendKey(ByVal componentName As String, ByVal keyPressed As Char)

        If setFocus(componentName) Then
            SendKeys.SendWait(keyPressed)

        Else
            Dim tempString As String = "Error in setting Focus: " & componentName & vbCrLf _
                                       & "Component was not found in the tab order." & vbCrLf
            errorList.Add(tempString)

        End If
    End Sub

    ' Sets the value of a data grid cell based on the coordinates (row, collum) given by the user.
    ' [row] In - The row in the DataGridCell to be found.
    ' [col] In - The collum in the DataGridCell to be found.
    ' [value] In - The value to be placed in the defined location.
    Public Sub setDataGridCell(ByVal row As String, ByVal col As String, ByVal value As String)

        Dim x As Integer = Val(row)
        Dim y As Integer = Val(col)

        testAssembly.setDataGridValue(x, y, value)

    End Sub

    ' Sets the focus to the a control specified.
    ' [componentName] In - The name of the component you want to set focus to.
    '
    ' Return: A boolean value of if the component was focused on.
    Public Function setFocus(ByVal componentName As String) As Boolean

        Return testAssembly.setControlFocus(componentName)

    End Function

    ' Sets a loaded form into focus from the users program. If the form has not been loaded an exception is thrown.
    ' [frmName] In - The name of the from to set focus to.
    Public Sub setForm(ByVal frmName As String)

        If Not testAssembly.setCurrentForm(frmName) Then

            Dim errorMessage As String = "Could not find form: " & frmName

            stopScriptExecution(errorMessage)

        End If
    End Sub

    ' Sets a property on a given form to a value specified by the user.
    ' This can be any unlocked property of the form.
    ' [formName] In - The name of the form in the assembly.
    ' [propertyName] In - The name of the property of the component.
    ' [value] In - The value or index the comboBox will be set to.
    Public Sub setFormProperty(ByVal formName As String, ByVal propertyName As String, ByVal value As String)

        testAssembly.setFormProperty(formName, propertyName, value)

    End Sub

    ' Set the index of a given listbox on the active form.
    ' [listBoxName] In - The name of the listBox to find.
    ' [index] In - The index to set the listBox to.
    Public Sub setListBoxIndex(ByVal listBoxName As String, ByVal index As String)

        testAssembly.changeListBoxIndex(listBoxName, Val(index))

    End Sub

    ' Sets a property of a control on the currentlyfocused form
    ' [controlName] In - The name of the control to be used
    ' [propertyName] In - Name of the property to be changed in the textbox.
    ' [value] In - The value of the property you are changing.
    Public Sub setProperty(ByVal controlName As String, ByVal propertyName As String, ByVal value As String)

        testAssembly.setControlProperty(controlName, propertyName, value)

    End Sub

    ' This tries set a value on a dataBase table by row/collum location, the end of the row, or the end of a collum, if the 
    ' table has already been loaded by the script. The row and collum parameters are only used if valLocation is equal to "valueat"."
    ' [variable] In - The name of the variable you are searching for in the table.
    ' [tableName] In - The Name of the table you are searching through.
    ' [valLocation] In - The method of finding the variable in the table. Can either be "valueat", "row" or "col".
    ' [row] In - The row the variable is located in on the table. Only used if valLocation is set to "valueat".
    ' [col] In - The collum the variable is located in on the table. Only used if valLocation is set to "valueat".
    'Public Sub setTableValue(ByVal variable As String, ByVal tableName As String, ByVal valLocation As String, ByVal row As String, ByVal col As String)

    '    If variables.ContainsKey(variable) Then
    '        variables.Remove(variable)

    '    End If

    '    If Not tables.ContainsKey(tableName) Then
    '        Throw New Exception("Table:" & tableName & " does not exist or was not loaded.")

    '    End If

    '    If valLocation.ToLower.Contains("valueat") Then
    '        Dim x As Integer = Val(row)
    '        Dim y As Integer = Val(col)
    '        Dim temp As String = tables(tableName)(x)(y)

    '        variables.Add(variable, temp)

    '    ElseIf valLocation.ToLower.Contains("row") Then
    '        variables.Add(variable, tables(tableName).Rows.Count)

    '    ElseIf valLocation.ToLower.Contains("col") Then
    '        variables.Add(variable, tables(tableName).Columns.Count)

    '    End If
    'End Sub

    ' Sets the total points that the program will be graded on.
    ' Also sets the score the user has, starting at max points.
    ' [totalPoints] In - The total points the program is worth.
    Public Sub setTotalPoints(ByVal totalPoints As Integer)

        totalScore = totalPoints
        finalScore = totalPoints

    End Sub

    ' Stops the script from executing and prints an error message.
    ' [errorMessage] In - Error to print to the console.
    Private Sub stopScriptExecution(ByVal errorMessage As String)

        Running = False

        Console.WriteLine("Grader Execution stopped because: " & errorMessage)

        errorList.Add("Grader execution was stopped" & vbCrLf & vbCrLf)
        errorList.Add(errorMessage & vbCrLf & vbCrLf)
        errorList.Add("Fix problem and resubmit solution" & vbCrLf)

    End Sub
End Class
