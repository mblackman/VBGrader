'-------------------------------------------------------------------------------------------------------------
' Name:        Chase Simmons, Ben VanSomeren, Matt Blackman, Jacob Noyes, Jacob Lange
' Date:        12/11/2012
' Last Edited: 03/12/2014
'-------------------------------------------------------------------------------------------------------------

Imports System.Runtime.InteropServices
Imports System.Text

' WindowsFunctions is importing many functionality from old VB libraries and putting
' the functionality of the libraries into functions to be used in this program.
' WindowsFunctions contains a few full functions which are used throughout the whole
' VBGrader solution.
Public Class WindowFunctions

    ' A delegate used as a method for alerting when the window enumeration is done.
    Public Delegate Function CallBack(ByVal hwnd As Integer, ByVal lParam As Integer) As Boolean

    ' A delegate to enumerate windows.
    Public Delegate Function EnumWindowsProc(ByVal hWnd As IntPtr, ByRef lParam As IntPtr) As Boolean

    ' Cross thread adding of child windows.
    Public Delegate Function EnumWindowProcess(ByVal Handle As IntPtr, ByVal Parameter As IntPtr) As Boolean

    ' Adds a handle to child windows.
    ' [Handle] In - Handle of window.
    ' [Paramter] In - Control on window you want to enumerate.
    '
    ' Return: Always returns true.
    Public Shared Function EnumWindow(ByVal Handle As IntPtr, ByVal Parameter As IntPtr) As Boolean

        Dim ChildrenList As List(Of IntPtr) = GCHandle.FromIntPtr(Parameter).Target

        If ChildrenList Is Nothing Then
            Throw New Exception("GCHandle Target could not be cast as List(Of IntPtr)")

        End If

        ChildrenList.Add(Handle)

        Return True

    End Function

    ' Function declaration for the windows enumeration. 
    ' [x] In - A CallBack to the window handle.
    ' [y] In - Handle of the window.
    '
    ' Return: Returns an Integer of the windows handle.
    '
    ' Notes: Needs to imported from user32.dll and defined by name.
    '        This declaration is nessisary to work in the GetWindows Function because
    '        the delegate is being called with unmanaged memory.
    Declare Function EnumWindows Lib "user32" (ByVal x As CallBack, ByVal y As Integer) As Integer

    ' Finds all Windows forms associated with the main form.
    ' [ParentHandle] In - Handle of the main window.
    '
    ' Return: Returns an IntPtr list of all the child windows handles.
    '
    ' Notes: Figure out what constitutes a child window.
    Public Shared Function GetChildWindows(ByVal ParentHandle As IntPtr) As IntPtr()

        Dim ChildrenList As New List(Of IntPtr)
        Dim ListHandle As GCHandle = GCHandle.Alloc(ChildrenList)

        Try
            EnumChildWindows(ParentHandle, AddressOf EnumWindow, GCHandle.ToIntPtr(ListHandle))

        Finally
            If ListHandle.IsAllocated Then ListHandle.Free()

        End Try

        Return ChildrenList.ToArray

    End Function

    ' Gets all text from all the controls on the given form.
    ' [hWnd] In - Pointer to control on Windows form to be evaluated.
    '
    ' Return: Returns the text if found, otherwise returns nothing.
    Public Shared Function GetText(ByVal hWnd As IntPtr) As String

        Dim returnVal = Nothing

        If hWnd.ToInt32 > 0 Then
            Dim length = GetWindowTextLength(hWnd)

            If length <> 0 Then
                Dim sb As New System.Text.StringBuilder("", length + 1)
                GetWindowText(hWnd, sb, sb.Capacity)
                returnVal = sb.ToString()

            End If
        End If

        Return returnVal

    End Function

    ' Gets the main running window of the program to be graded.
    '
    ' Return: Returns an pointer to the main window.
    Public Shared Function GetWindows() As IntPtr()

        Dim handleList As New List(Of IntPtr)
        Dim ListHandle As GCHandle = GCHandle.Alloc(handleList)

        Try
            EnumWindows(AddressOf EnumWindow, GCHandle.ToIntPtr(ListHandle))

        Finally
            If ListHandle.IsAllocated Then ListHandle.Free()

        End Try

        Return handleList.ToArray

    End Function

    ' Import for User32 EnumChildWindows.
    <DllImport("User32.dll")> _
    Public Shared Function EnumChildWindows( _
        ByVal WindowHandle As IntPtr, ByVal Callback As EnumWindowProcess, _
        ByVal lParam As IntPtr) As Boolean
    End Function

    ' Import for User32 EnumWindows.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function EnumWindows( _
        ByVal lpEnumFunc As EnumWindowsProc, _
        ByVal lParam As IntPtr) As Boolean
    End Function

    ' Import for User32 FinedWindow.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function FindWindow( _
        ByVal lpClassName As String, _
        ByVal lpWindowName As String) As IntPtr
    End Function

    ' Import for Users32 FindWindowEx.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function FindWindowEx( _
        ByVal parentHandle As IntPtr, _
        ByVal childAfter As IntPtr, _
        ByVal lclassName As String, _
        ByVal windowTitle As String) As IntPtr
    End Function

    ' Import for User32 GetWindow.
    <DllImport("user32", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function GetWindow(ByVal hwnd As IntPtr, ByVal uCmd As Integer) As IntPtr
    End Function

    ' Import for User32 GetWindowText.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function GetWindowText(ByVal hwnd As IntPtr, ByVal lpString As StringBuilder, ByVal cch As Integer) As Integer
    End Function

    ' Import for User32 GetWindowTextLength.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function

    ' Import for User32 PostMessage.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    End Function

    ' Import for User32 SendMessage.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    ' Import for User32 SetWindowText.
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Shared Function SetWindowText(ByVal hwnd As IntPtr, ByVal lpString As String) As Boolean
    End Function

End Class


