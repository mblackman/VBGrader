'-------------------------------------------------------------------------------------------------------------
' Name:        Chase Simmons, Ben VanSomeren, Matt Blackman, Jacob Noyes, Jacob Lange
' Date:        12/11/2012
' Last Edited: 03/12/2014
'-------------------------------------------------------------------------------------------------------------

Imports System.Reflection
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.ComponentModel
Imports System.IO

' AssemblyImage loads a program from a given executable path and contains the actions nessisary
' to manipulate properties of the form and its controls, along with sending and recieving data, and 
' sending clicks.
Public Class AssemblyImage

#Region "Variables"

    Private testAssembly As Assembly                                ' The actual assembly image.

    Private values As New Dictionary(Of String, String)              'Stores some generic variables including the message box text.
    Private toolStripButtons As New Dictionary(Of String, String)    'Collection of toolstripbuttons.

    Private delegateComboBoxValue As String                         'Temporary ComboBox. Used to bypass cross thread errors.
    Private listBoxDelegateValue As ListBox                                     'Temporary ListBox. Used to bypass cross thread errors.

    Private childrenHandles() As IntPtr                             'List of pointers of all components in the GUI.
    Private _currentForm As Form                                    'The active form in the GUI.
    Private curFrmHandle As IntPtr                                  'The active pointer.
    Private _activeControl As String = ""                           'Used to find the control with focus.

    Private stillGrading As Boolean

    Private _allForms As New Dictionary(Of String, Form)  'A list of all forms in the VB GUI.

    Private flags As BindingFlags = BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Static Or BindingFlags.Instance  'Flags for the form components.

    Private _filePath As String                                     'Path of the GUI.

    Private _printResults As [Delegate]                             'Delegate to print the results of the tests.
    Private _mainForm As Form                                       'Main form of the GUI.

    Private formExecutionCompleteSemaphore As Semaphore

    Dim trdTestForm As Thread
    Dim trdRunTest As Thread

#End Region

#Region "Delegate Variables"

    ' Delegates the changing of selected indexes in listboxes.
    Public Delegate Sub changeListBoxSelectedIndex(ByVal componentName As String, ByVal index As Integer)

    ' Delegates the click action.
    Public Delegate Sub clickDelegate(ByVal componentName As String)

    ' Delegates closing of forms
    Public Delegate Sub closeFormDel(ByRef form As Form)

    ' Delegates the form pointers.
    Public Delegate Sub currentFormHandle()

    ' Delegate to get comboBox
    Public Delegate Sub getComboBox(ByVal comboBoxName As String, ByVal propertyName As String)

    ' Delegates the retrieval of listbox info.
    Public Delegate Sub getLstBox(ByVal listBoxName As String)

    Public Delegate Sub setControlPropDelegate(ByVal formName As String, ByVal propertyName As String, ByVal value As String)

    ' Delegates the set properties action.
    Public Delegate Sub setDelegate(ByVal parms As List(Of String))

    Public Delegate Sub setComboBoxDelegate(ByVal comboBoxName As String, ByVal propertyName As String, ByVal value As String)

#End Region

#Region "Properties"

    ' GG3340
    ' Gets and sets the active control. 
    ' I don't know if setting works. This was implemented by Greg Gramm, I believe.
    Public Property ActiveControl() As String

        Get
            Return _activeControl

        End Get

        Set(ByVal value As String)
            _activeControl = value

        End Set
    End Property

#End Region

#Region "Assembly Init"

    ' Default constructor, which takes in the executable path of the program to be graded.
    ' [exePath] In - The executable path of the program to be graded.
    Public Sub New(ByVal exePath As String)

        _filePath = exePath

    End Sub

    ' Invokes a method on a given form as specified by the user.
    ' This can invoke any method availible on the form if the user has permissions.
    ' [form] In - The form to perform the action on.
    ' [methodName] In - The name of the method to be invoked.
    ' [params] In - Any params the method may require.
    Public Sub InvokeMethod(ByVal form As Form, ByVal methodName As String, ByVal parms As Object())

        Dim eh As EventHandler = System.Delegate.CreateDelegate(GetType(EventHandler), form, methodName)

        If eh <> Nothing Then
            form.Invoke(eh, parms)

        End If
    End Sub

    ' Runs the test file on the target form.
    ' [state] In - Some sort of thing needed for threading.
    ' 3-31-13: Qi Yang
    '         Changed trdTestForm.Abort() to _currentForm.Invoke(delegateVariable)
    '         Abort gave run time error when grade the 2nd or later exe files
    Private Sub runFormTest(ByVal state As Object)

        Dim p() As Object = {Me, New EventArgs()}

        stillGrading = True

        Console.WriteLine("In runFormTest")
        Console.WriteLine("Starting Test")

        Try
            Dim messageBoxthread = New Thread(AddressOf runMessageBoxTest)
            messageBoxthread.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    ' Exits all the running threads and form in the assembly.
    ' Sets a bool value to false to stop the assembly from scanning for popup windows.
    ' Closes all the forms, then joins all the threads.
    Public Sub stopAssembly()

        stillGrading = False

        For Each loadedForm In _allForms.Values

            If loadedForm.IsHandleCreated Then

                loadedForm.Invoke(New closeFormDel(AddressOf _closeForm), loadedForm)

            End If
        Next

        If Not IsNothing(trdTestForm) Then

            trdTestForm.Join()

        End If

        If Not IsNothing(trdRunTest) Then

            trdRunTest.Join()

        End If
    End Sub

    ' Tests the program provided that all properties are valid properties.
    ' [mainFormName] In - Name of the main form
    '
    ' Return: If the main form was loaded or not.
    Public Function testProgram(ByVal mainFormName As String) As Boolean

        testAssembly = Assembly.UnsafeLoadFrom(_filePath)

        loadForms()

        If _allForms.ContainsKey(mainFormName) Then

            _currentForm = _allForms(mainFormName)

            trdTestForm = New Thread(AddressOf runForm)
            trdRunTest = New Thread(AddressOf runFormTest)

            trdTestForm.Start()
            trdRunTest.Start()

            Return True

        Else
            Return False

        End If
    End Function

#End Region

#Region "Functions"

    ' Base constructor which adds binding navigator controls to values
    Public Sub New()

        values.Add("bn-btn-first", "move first")
        values.Add("bn-btn-previous", "move previous")
        values.Add("bn-btn-next", "move next")
        values.Add("bn-btn-last", "move last")
        values.Add("bn-btn-new", "add new")
        values.Add("bn-btn-delete", "delete")
        values.Add("bn-btn-save", "save")
        values.Add("bn-btn-reload", "reload")
        values.Add("bn-btn-list", "list")
        values.Add("bn-btn-exit", "exit")

    End Sub

    ' Adds a form to the list of active forms.
    ' [formName] In - The name of he form. This is used as a key to identify the form.
    ' [formObj] In - The form to be added to the list.
    Public Sub addForm(ByVal formName As String, ByRef formObj As Form)

        _allForms.Add(formName, formObj)

    End Sub

    ' Finds a listbox based on user input and changes the index of its current selection.
    ' [listBoxName] In - The name of the listBox you are searching for.
    ' [index] In - The index you want to set the listBox to.
    Public Sub changeListBoxIndex(ByVal listBoxName As String, ByVal index As Integer)

        _currentForm.Invoke(New changeListBoxSelectedIndex(AddressOf _changeListboxIndex), listBoxName, index)

    End Sub

    ' Finds a listbox based on user input and changes the index of its current selection.
    ' This function is invoked through a delegate from changeListBoxIndex().
    ' [listBoxName] In - The name of the listBox you are searching for.
    ' [index] In - The index you want to set the listBox to.
    Private Sub _changeListboxIndex(ByVal listBoxName As String, ByVal index As Integer)

        Try
            Dim lst As ListBox = getListbox(listBoxName)
            lst.SelectedIndex = index

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    ' For the currently selected Windows Form, if the form has a bindingNavigator, then
    ' this will click a button, as defined by a user, on that bindingNavigator.
    ' [buttonName] In - Name of the button on the bindingNavigator that will be clicked.
    '                   This value can be: "move first", "move previous", "move next",
    '                   "move last", "add new", "delete", save data", "reload", "list", "exit"
    Public Sub clickBindingNavigator(ByVal buttonName As String)

        _currentForm.Invoke(New clickDelegate(AddressOf _clickBindingNavigator), values(buttonName))

    End Sub

    ' For the currently selected Windows Form, if the form has a bindingNavigator, then
    ' this will click a button, as defined by a user, on that bindingNavigator.
    ' This function is invoked through a delegate from clickBindingNavigator().
    ' [buttonName] In - Name of the button on the bindingNavigator that will be clicked.
    '                   This value can be: "move first", "move previous", "move next",
    '                   "move last", "add new", "delete", save data", "reload", "list", "exit"
    Public Sub _clickBindingNavigator(ByVal buttonName As String)

        Dim tempBindingNavigator As BindingNavigator = getBindingNavigator()
        Dim toolStripItems As ToolStripItemCollection
        Dim temp As Form = _currentForm
        Dim tempButtonName As String = buttonName

        toolStripItems = tempBindingNavigator.Items()

        If values.ContainsKey(buttonName.ToLower) Then
            tempButtonName = values(buttonName.ToLower)

        End If

        Try
            Select Case tempButtonName.ToUpper
                Case "MOVE FIRST"
                    tempBindingNavigator.MoveFirstItem.PerformClick()

                Case "MOVE PREVIOUS"
                    tempBindingNavigator.MovePreviousItem.PerformClick()

                Case "MOVE NEXT"
                    tempBindingNavigator.MoveNextItem.PerformClick()

                Case "MOVE LAST"
                    tempBindingNavigator.MoveLastItem.PerformClick()

                Case "ADD NEW"
                    tempBindingNavigator.AddNewItem.PerformClick()

                Case "DELETE"
                    tempBindingNavigator.DeleteItem.PerformClick()

                Case "SAVE DATA"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("SAVE DATA") Then
                            item.PerformClick()
                            Exit For

                        End If
                    Next

                Case "RELOAD"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("RELOAD") Then
                            item.PerformClick()
                            Exit For

                        End If
                    Next

                Case "LIST"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("LIST") Then
                            item.PerformClick()
                            Exit For

                        End If
                    Next

                Case "EXIT"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("EXIT") Then
                            item.PerformClick()
                            Exit For

                        End If
                    Next

            End Select

        Catch ex As Exception
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine(ex)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine(ex.TargetSite)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine(ex.Source)
            Console.WriteLine("-------------------------------------------")
            Console.WriteLine("Error pressing binding navigator button")
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    ' Closes a form sent.
    ' Used by a delegate so this can access the graded programs thread.
    ' [form] In - The form to be closed.
    '
    ' Notes: This doesn't work for all cases, but could be worked to do so.
    Private Sub _closeForm(ByRef form As Form)

        'Dim formHandle As IntPtr = form.Handle

        'Dim WM_SYSCOMMAND = &H112
        'Dim SC_CLOSE = &HF060

        'WindowFunctions.SendMessage(formHandle, WM_SYSCOMMAND, SC_CLOSE, 0)

        form.Close()

    End Sub

    ' Checks if the form is in the list of loaded forms.
    ' 
    ' Return: True or false if the form is in the list of forms.
    Public Function containsForm(ByVal formName As String) As Boolean

        Return _allForms.ContainsKey(formName)

    End Function

    ' Finds a toolstrip menu item on the menustrip and returns the name of the strip.
    ' [itemName] In - Name of the stripMenu you are looking for
    '
    ' Return: If the toolStripMenuItem was found or not
    Public Function findToolStripItem(ByVal itemName As String) As Boolean

        Dim tempMenuStrip As MenuStrip = getMenuStrip()
        Dim foundItem As Boolean = False

        If Not tempMenuStrip Is Nothing Then
            For i As Integer = 0 To tempMenuStrip.Items.Count - 1

                Dim subMenu1 As ToolStripMenuItem = tempMenuStrip.Items.Item(i)

                If subMenu1.GetType.FullName Is GetType(System.Windows.Forms.ToolStripMenuItem).FullName Then

                    If subMenu1.Name = itemName Then

                        foundItem = True

                    End If

                    For j As Integer = 0 To subMenu1.DropDownItems.Count - 1

                        Dim tempStripItem = subMenu1.DropDownItems.Item(j)

                        If tempStripItem.GetType.FullName Is GetType(System.Windows.Forms.ToolStripMenuItem).FullName Then

                            If tempStripItem.Name = itemName Then

                                foundItem = True

                            End If
                        End If
                    Next
                End If
            Next
        End If

        Return foundItem

    End Function

    ' Gets the ActiveControl, which is the control on the active form, which is focused.
    ' The active control name is added to a class variable because of threading.
    Public Sub GetActiveControl()

        If _currentForm.InvokeRequired Then
            _currentForm.Invoke(New MethodInvoker(AddressOf _getFocus))

        Else
            ActiveControl = _currentForm.ActiveControl.Name.ToString

        End If

    End Sub

    ' Gets the BindingNavigator on the currently focused Windows Form and returns that
    ' BindingNavigator.
    '
    ' Return: Returns the BindingNavigator on the current form.
    Private Function getBindingNavigator() As BindingNavigator

        getCurrentFormHandle()

        Dim currentHandle As IntPtr = curFrmHandle
        Dim tempBindingNavigator As BindingNavigator = New BindingNavigator

        childrenHandles = WindowFunctions.GetChildWindows(currentHandle)

        For Each ptr As IntPtr In childrenHandles
            Try
                tempBindingNavigator = BindingNavigator.FromHandle(ptr)

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Next

        Return tempBindingNavigator

    End Function

    ' Gets the BindingNavigator button off the focused Windows Form.
    ' [buttonName] In - Name of the button on the bindingNavigator that will be clicked.
    '                   This value can be: "move first", "move previous", "move next",
    '                   "move last", "add new", "delete", save data", "reload", "list", "exit"
    '
    ' Return: Returns the BindingNavigator button if found, else Nothing
    Public Function getBindingNavigatorButton(ByVal buttonName As String) As ToolStripItem

        getCurrentFormHandle()

        Dim handleOfForm As IntPtr = curFrmHandle
        Dim tempBindingNavigator As BindingNavigator = getBindingNavigator()
        Dim toolStripItems As ToolStripItemCollection

        toolStripItems = tempBindingNavigator.Items()

        Try
            Select Case buttonName.ToUpper
                Case "MOVE FIRST"
                    Return tempBindingNavigator.MoveFirstItem

                Case "MOVE PREVIOUS"
                    Return tempBindingNavigator.MovePreviousItem

                Case "MOVE NEXT"
                    Return tempBindingNavigator.MoveNextItem

                Case "MOVE LAST"
                    Return tempBindingNavigator.MoveLastItem

                Case "ADD NEW"
                    Return tempBindingNavigator.AddNewItem

                Case "DELETE"
                    Return tempBindingNavigator.DeleteItem

                Case "SAVE DATA"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("SAVE DATA") Then
                            Return item

                        End If
                    Next

                Case "RELOAD"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("RELOAD") Then
                            Return item

                        End If
                    Next

                Case "LIST"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("LIST") Then
                            Return item

                        End If
                    Next

                Case "EXIT"
                    For Each item As ToolStripItem In toolStripItems
                        If item.ToString.ToUpper.Contains("EXIT") Then
                            Return item

                        End If
                    Next

            End Select

        Catch ex As Exception
            Console.WriteLine("Error getting binding navigator button")
            MessageBox.Show(ex.Message)

        End Try

        Return Nothing

    End Function

    ' Gets rather the currently selected index or text from a comboBox that is being searched for.
    ' [comboBoxName] In - The name of the comboBox being searched for.
    ' [propertyName] In - The property of the comboBox desires. Either "selectedindex" or "text".
    Public Function getComboBoxValue(ByVal comboBoxName As String, ByVal propertyName As String) As String

        Dim cDel As New getComboBox(AddressOf _getComboBoxValue)

        _currentForm.Invoke(cDel, comboBoxName, propertyName)

        Return delegateComboBoxValue

    End Function

    ' Gets rather the currently selected index or text from a comboBox that is being searched for.
    ' This function is invoked through a delegate from getComboBoxValue().
    ' [comboBoxName] In - The name of the comboBox being searched for.
    ' [propertyName] In - The property of the comboBox desires. Either "selectedindex" or "text".
    Private Sub _getComboBoxValue(ByVal comboBoxName As String, ByVal propertyName As String)

        getCurrentFormHandle()

        Dim temp As IntPtr = curFrmHandle
        Dim cb As ComboBox = New ComboBox

        childrenHandles = WindowFunctions.GetChildWindows(temp)

        Try
            For Each ptr As IntPtr In childrenHandles
                If cb.Name = comboBoxName Then
                    cb = ComboBox.FromHandle(ptr)

                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        If Not IsNothing(cb) Then
            If propertyName.ToLower = "selectedindex" Then
                delegateComboBoxValue = cb.SelectedItem

            ElseIf propertyName.ToLower = "text" Then
                delegateComboBoxValue = cb.Text

            End If
        End If
    End Sub

    ' Gets the actual name of a specified component. Loops through all of the pointers creating the specified 
    ' component type until it creates one succesfully with the same name as the specified component. Then records
    ' its x and y position.
    ' [controlName] In - The name of the control you are searching for.
    ' [controlType] In - The type of control that you are searching for.
    '
    ' Return: If the control can be found on the form or not.
    Public Function findFormControl(ByVal controlName As String, ByVal controlType As String) As Boolean

        Dim found As Boolean = False

        getCurrentFormHandle()
        childrenHandles = WindowFunctions.GetChildWindows(curFrmHandle)

        For Each cptr As IntPtr In childrenHandles

            Dim tempControl = Control.FromHandle(cptr)

            If Not tempControl Is Nothing Then
                If tempControl.GetType().Name.ToUpper = controlType.ToUpper Then
                    If tempControl.Name = controlName Then

                        found = True

                    End If
                End If
            End If
        Next

        Return found

    End Function

    ' Looks through all the controls on the current form and tries to return that control
    ' [controlName] In - Name of the control you are searching for.
    '
    ' Return: The searched for control or vbNull
    Private Function getControl(ByVal controlName As String) As Control

        Dim myControl As Control = Nothing

        getCurrentFormHandle()
        childrenHandles = WindowFunctions.GetChildWindows(curFrmHandle)

        For Each ptr As IntPtr In childrenHandles

            Dim temp As Control = Control.FromHandle(ptr)

            If Not temp Is Nothing Then
                If temp.Name.Contains(controlName) Then

                    myControl = temp

                End If
            End If
        Next

        Return myControl

    End Function

    ' Gets the currently focused form.
    ' 
    ' Return: The currently focused form.
    Public Function getCurrentForm() As Form

        Return _currentForm

    End Function

    ' Gets the currentform pointer.
    ' Used as a delegate, and invokes the method _getCurrentFormHandle
    Public Sub getCurrentFormHandle()

        Try
            Dim Del As New currentFormHandle(AddressOf _getCurrentFormHandle)
            _currentForm.Invoke(Del)

        Catch ex As Exception

        End Try
    End Sub

    ' Gets the currentform pointer and addresses it to a class variable to overcome threading. Unlike me.
    Public Sub _getCurrentFormHandle()

        curFrmHandle = _currentForm.Handle

    End Sub

    ' Gets the name of the current form.
    '
    ' Return: The name of the current form.
    Public Function getCurrentFormHeader() As String

        Return _currentForm.Text

    End Function

    ' Gets the value from a datagrid cell in the currently focused form by location.
    ' [row] In - The row in the table the value is.
    ' [col] In - The collum in the table the value is.
    '
    ' Return: The value from the dataGridView.
    Public Function getDataGridValue(ByVal row As Integer, ByVal col As Integer) As String

        Try
            getCurrentFormHandle()

            Dim dgv As DataGridView = getDataGridView()
            Dim value As String = ""

            If dgv.Rows(row).Cells.Item(col).ValueType = GetType(Boolean) Then
                Dim check As Boolean = dgv.Rows(row).Cells.Item(col).Value

                Return check.ToString

            End If

            Return dgv.Rows(row).Cells.Item(col).Value.ToString

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message)

            Return ""

        End Try
    End Function

    ' Looks at the currently focused Windows Form and finds a DataGridView
    ' and returns that DataGridView.
    '
    ' Return: Returns a DataGridView on the currently focused Windows Form.
    Private Function getDataGridView() As DataGridView

        getCurrentFormHandle()

        Dim tempDataGridView As DataGridView = New DataGridView
        Dim temp As IntPtr = curFrmHandle

        childrenHandles = WindowFunctions.GetChildWindows(temp)

        For Each ptr As IntPtr In childrenHandles
            Try
                tempDataGridView = DataGridView.FromHandle(ptr)

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Next

        Return tempDataGridView

    End Function

    ' Gets the specified field from an object.
    ' The object can be anything really.
    ' [obj] In - The object whose field you want.
    ' [fieldName] In - The field name from the object whose value will get returned.
    '
    ' Return: The field from the object the user looked for, or Nothing if nothing is found.
    Private Function _GetField(ByVal obj As Object, ByVal fieldName As String) As Object

        Dim t As Type = obj.GetType()
        Dim fi As FieldInfo = t.GetField(fieldName, flags)

        Dim stuff = t.GetFields(flags)

        Return fi.GetValue(obj)

    End Function

    ' Gets the currently focused Windows form.
    Private Sub _getFocus()

        GetActiveControl()

    End Sub

    ' Gets a ListBox on the currently focused Windows Form.
    ' [listBoxName] In - The name of the listBox you are looking for.
    '
    ' Return: Returns the ListBox found by the searched name.
    Public Function getListbox(ByVal listBoxName As String) As ListBox

        Dim cDel As New getLstBox(AddressOf _getListBox)
        _currentForm.Invoke(cDel, listBoxName)

        Return listBoxDelegateValue

    End Function

    ' Gets a ListBox on the currently focused Windows Form.
    ' This function is invoked through a delegate from getListbox().
    ' [listBoxName] In - The name of the listBox you are looking for.
    '
    ' Return: Returns the ListBox found by the searched name.
    Private Sub _getListBox(ByVal listBoxName As String)

        getCurrentFormHandle()

        Dim temp As IntPtr = curFrmHandle
        Dim lstBox As ListBox = New ListBox

        childrenHandles = WindowFunctions.GetChildWindows(temp)

        For Each ptr As IntPtr In childrenHandles
            Try
                Dim templ As New ListBox

                templ = ListBox.FromHandle(ptr)

                If templ.Name = listBoxName Then
                    lstBox = templ
                    Exit For

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Next

        listBoxDelegateValue = lstBox

    End Sub

    ' Gets the property from a control on the currently focused Windows Form.
    ' [componentName] In - The name of the control on the form.
    ' [propertyName] In - The name of the property in the control.
    '
    ' Return: The property from the control.
    Public Function GetProperty(ByRef componentName As String, ByRef propertyName As String) As Object

        If componentName = "EmpIDListBox" Then
            Console.Write("")

        End If

        If _allForms.ContainsKey(componentName) Then
            Return _GetProperty(_currentForm, propertyName)

        ElseIf values.ContainsKey(componentName.ToLower) Then
            Return _GetProperty(getBindingNavigatorButton(values(componentName.ToLower)), propertyName)

        ElseIf propertyName.Contains(".") Then
            Dim tempArgs = propertyName.Split(".")
            Dim tempCount As Integer = 1
            Dim tempObject As Object = _GetProperty(_GetField(_currentForm, "_" & componentName), tempArgs(0))

            While tempCount < tempArgs.Count
                If tempArgs(tempCount).Contains("(") Then
                    tempObject = tempObject.item(tempArgs(tempCount).Split({"("c, ")"c})(1))

                Else
                    tempObject = _GetProperty(tempObject, tempArgs(tempCount))

                End If

                tempCount += 1

            End While

            Return tempObject

        Else
            Return _GetProperty(_GetField(_currentForm, "_" & componentName), propertyName)

        End If
    End Function

    ' Gets the property from a control on the currently focused Windows Form.
    ' [componentName] In - The name of the control on the form.
    ' [propertyName] In - The name of the property in the control.
    '
    ' Return: The property from the control.
    Private Function _GetProperty(ByVal componentName As Object, ByVal propertyName As String)

        Dim t As Type = componentName.GetType()
        Dim pi As PropertyInfo = t.GetProperty(propertyName, flags)

        Return pi.GetValue(componentName, Nothing)

    End Function

    ' Gets the ToolStrip from the currently focused Windows Form.
    '
    ' Return: Returns the toolstrip found.
    Private Function getMenuStrip() As MenuStrip

        Dim ptr As IntPtr = curFrmHandle
        Dim tempMenuStrip As MenuStrip = Nothing
        Dim menuItems = New Dictionary(Of String, ToolStripMenuItem)
        Dim returnMenuItem As ToolStripMenuItem = Nothing

        childrenHandles = WindowFunctions.GetChildWindows(ptr)

        For Each cptr As IntPtr In childrenHandles

            Dim tempControl As Control = Control.FromHandle(cptr)

            If Not tempControl Is Nothing Then

                If tempControl.GetType().FullName Is GetType(System.Windows.Forms.MenuStrip).FullName Then

                    tempMenuStrip = tempControl

                End If
            End If
        Next

        Return tempMenuStrip

    End Function

    ' Gets the value of the specified variable if it exists.
    ' [variableName] In - The name of the control on the Windows forms.
    '
    ' Return: The value of the control, else an empty string if nothing is found.
    Public Function getValue(ByRef variableName As String) As String

        If values.ContainsKey(variableName) Then
            Return values(variableName)

        Else
            Return ""

        End If
    End Function

    ' Loads all the forms in the assembly and adds them to a container.
    Public Sub loadForms()

        For Each ty As Type In testAssembly.GetTypes()
            If ty.BaseType.Name = "Form" Then

                Dim tempForm As Form = testAssembly.CreateInstance(ty.FullName)

                addForm(tempForm.Name, tempForm)

            End If
        Next
    End Sub

    ' Removes a form from the list of forms.
    ' [formName] In - The name of the form to be removed.
    Public Sub removeForm(ByVal formName As String)

        _allForms.Remove(formName)

    End Sub

    ' Shows the form that will be graded from the user's program.
    ' [state] In - Some threading thing.
    ' 3-31-13: Qi Yang
    '          Changed Application.Run(_currentForm) to _currentForm.ShowDialog()
    '             to avoid run time error when grade 2nd or later exe files
    Public Sub runForm(ByVal state As Object)

        Try
            'Application.Run(_currentForm)
            _currentForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    ' Tests for a message box and gets the text of the message box if it finds one. Runs constantly looking for messageboxes.
    ' Will continuously loop until stillGrading is set to false.
    ' [state] In - Some threading thing.
    ' 3-27-13: Qi Yang
    '          Changed msgLabel to msgLabel_line1 and msgLabel_line2
    '          Added msgCaption
    Public Sub runMessageBoxTest(ByVal state As Object)

        Dim dialogPtr As IntPtr

        'Find way to stop this threads execution
        While stillGrading

            getCurrentFormHandle()
            dialogPtr = WindowFunctions.GetWindow(curFrmHandle, 6)

            If (dialogPtr <> 0) Then
                ' Can we find the icon info for the messagebox? 
                Thread.Sleep(10)

                Dim dialogChildren() As IntPtr = WindowFunctions.GetChildWindows(dialogPtr)

                For Each c As IntPtr In dialogChildren
                    Dim text As String = WindowFunctions.GetText(c)

                    If text <> "" And text <> "OK" Then
                        Dim pos As Integer
                        Dim str1, str2 As String

                        pos = text.IndexOf(vbCrLf)

                        If pos > 0 Then
                            str1 = text.Substring(0, pos)
                            str2 = text.Substring(pos + 2)

                            If values.ContainsKey("msgLabel_line1") Then
                                values.Remove("msgLabel_line1")

                            End If
                            If values.ContainsKey("msgLabel_line2") Then
                                values.Remove("msgLabel_line2")

                            End If

                            values.Add("msgLabel_line1", str1)
                            values.Add("msgLabel_line2", str2)

                        Else
                            If values.ContainsKey("msgLabel_line1") Then
                                values.Remove("msgLabel_line1")

                            End If
                            values.Add("msgLabel_line1", text)

                        End If

                        Dim str As String = WindowFunctions.GetText(dialogPtr)

                        If str = "" Then
                            str = "No msgCaption"

                        End If

                        If values.ContainsKey("msgCaption") Then
                            values.Remove("msgCaption")

                        End If

                        values.Add("msgCaption", str)

                    ElseIf text Is Nothing Then
                        'msgboxicon?
                    End If

                Next

                WindowFunctions.PostMessage(dialogPtr, &H10, Nothing, Nothing)

            End If
        End While
    End Sub

    ' Sets a control into focus by name of control and returns if focused
    ' [controlName] In - Name of the control you wish to focus
    '
    ' Return: If the control was focused or not
    Public Function setControlFocus(ByVal controlName As String) As Boolean

        Dim myControl As Control = getControl(controlName)

        myControl.Focus()

        Return myControl.Focused

    End Function

    ' Sets a property of a given control on the current form.
    ' [controlName] In - Name of the control on the form.
    ' [propertyName] In - Name of the property to be changed.
    ' [setValue] In - The value desired to set the property to.
    Public Sub setControlProperty(ByVal controlName As String, ByVal propertyName As Object, ByVal setValue As String)

        Dim setPropertyThread As New setControlPropDelegate(AddressOf _setControlProperty)

        _currentForm.Invoke(setPropertyThread, controlName, propertyName, setValue)

        'setPropertyThread.Start(controlName, propertyName, setValue)

        'WindowFunctions.SendMessage(controlPointer, &HC, Nothing, Marshal.StringToHGlobalAuto(setValue))

    End Sub

    ' Sets a property of a given control on the current form.
    ' This is the delegate function
    ' [controlName] In - Name of the control on the form.
    ' [propertyName] In - Name of the property to be changed.
    ' [setValue] In - The value desired to set the property to.
    Private Sub _setControlProperty(ByVal controlName As String, ByVal propertyName As Object, ByVal setVal As String)

        Dim myControl As Control = getControl(controlName)

        If Not myControl Is Nothing Then

            Dim controlProperty = myControl.GetType().GetProperty(propertyName, flags)

            If (Not controlProperty Is Nothing And controlProperty.CanWrite) Then

                controlProperty.SetValue(myControl, setVal, Nothing)

            End If

        End If

    End Sub

    ' Sets the value of a cell on a dataGridVied on the currently focused form.
    ' [row] In - Row on the DataGridView for the value.
    ' [col] In - Collum on the DataGridView for the value.
    ' [value] - Value you want to set on the dataGridView cell.
    Public Sub setDataGridValue(ByVal row As Integer, ByVal col As Integer, ByVal value As String)

        getCurrentFormHandle()

        Dim dgv As DataGridView = getDataGridView()

        Try
            If dgv.Rows(row).Cells.Item(col).ValueType = GetType(Boolean) Then
                If value.ToUpper = "TRUE" Then
                    dgv.Rows(row).Cells.Item(col).Value = True
                Else
                    dgv.Rows(row).Cells.Item(col).Value = False
                End If
            Else
                dgv.Rows(row).Cells.Item(col).Value = value
            End If
        Catch ex As Exception
            Console.WriteLine("Error setting Data Grid Value")
            Console.WriteLine(ex.Message)
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    ' Sets the current form based on a string passed by a user.
    ' [formName] In - Name of the form you with to set to.
    '
    ' Return: If the form was found or not.
    Public Function setCurrentForm(ByVal formName As String) As Boolean

        _currentForm = _allForms(formName)

        If IsNothing(_currentForm) Then
            Return False

        Else
            Return True

        End If
    End Function

    ' Sets a property on an active form the user has specified.
    ' [formName] In - The name of the form whose property you are looking for.
    ' [propertyName] In - The name of the property on the current form.
    ' [value] In - The value to set the property to.
    Public Sub setFormProperty(ByVal formName As String, ByVal propertyName As String, ByVal value As String)

        Dim cDel As New setDelegate(AddressOf _setFormProperty)
        Dim parms As List(Of String) = New List(Of String)

        parms.Add(formName)
        parms.Add(propertyName)
        parms.Add(value)

        Dim frm As Form = _currentForm.Invoke(cDel, parms)

    End Sub

    ' Sets a property on an active form the user has specified.
    ' [formName] In - The name of the form whose property you are looking for.
    ' [propertyName] In - The name of the property on the current form.
    ' [value] In - The value to set the property to.
    '
    ' Notes: Bad function, but do we need it at all?
    Private Sub _setFormProperty(ByVal parms As List(Of String))

        childrenHandles = WindowFunctions.GetWindows()

        Dim frm As New Form

        For Each ptr As IntPtr In childrenHandles
            Try
                frm = Form.FromHandle(ptr)

                If frm.Name = parms(0) Then
                    Exit For

                End If

            Catch ex As Exception

            End Try
        Next

        If parms(1).ToLower = "width" Then
            frm.Width = Integer.Parse((parms(2).ToString.Trim))

        ElseIf parms(1).ToLower = "height" Then
            frm.Height = Integer.Parse((parms(2).ToString.Trim))

        End If
    End Sub

    ' Determines component names based on position on the screen.
    ' [control1] In - First control to be compared against.
    ' [control2] In - Second control to be compared against.
    Private Shared Function sortByPosition(ByVal control1 As Control, ByVal control2 As Control) As Integer

        If control1 Is Nothing Then
            If control2 Is Nothing Then
                Return 0

            Else
                Return -1

            End If

        Else
            If control2 Is Nothing Then
                Return 1

            Else
                If control1.Location.X < control2.Location.X Then
                    Return -1

                ElseIf control1.Location.X = control2.Location.X And control1.Location.Y < control2.Location.Y Then
                    Return -1

                ElseIf control1.Location.X = control2.Location.X And control1.Location.Y = control2.Location.Y Then
                    Return 0

                Else
                    Return 1

                End If
            End If
        End If
    End Function

#End Region

End Class