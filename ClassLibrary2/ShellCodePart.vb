Imports System.Windows.Forms
Imports TouchTest
Imports TouchTest.CustomController_Data

Public Class ShellCodePart
    Implements TouchTest.CustomController_Data.CustomController_Interface

    Public Shared Form1 As Form1
    Public Shared UI As UI
    Public Shared TryController As TryController

    Public Shared TheFormCollection As FormCollection
    Public Shared Hosty As TouchTest.CustomController_Data.CustomController_UI_Handler

    Public ReadOnly Property Name As String Implements CustomController_Interface.Name
        Get
            Return "Bring Back Usercontrols"
        End Get
    End Property

    Public ReadOnly Property VerifyedCode_ID As String Implements CustomController_Interface.VerifyedCode_ID
        Get
            Return "936352"
        End Get
    End Property

    Public ReadOnly Property RemoveTaskbar As Boolean Implements CustomController_Interface.RemoveTaskbar
        Get
            Return False
        End Get
    End Property

    Public Sub ExecuteForm1Subs(Form1_Form As Form1) Implements CustomController_Interface.ExecuteForm1Subs
        Form1 = Form1_Form
    End Sub

    Public Sub ExecuteUISubs(UI_Form As UI) Implements CustomController_Interface.ExecuteUISubs
        UI = UI_Form
    End Sub

    Public Shared TheNewOne As New TheOne

    Public Sub ExecuteTryControllerSubs(TryController_Form As TryController) Implements CustomController_Interface.ExecuteTryControllerSubs
        TryController = TryController_Form
        TheNewOne.Show()
    End Sub

    Public Sub ConfigFormCollection(Collection As FormCollection) Implements CustomController_Interface.ConfigFormCollection
        TheFormCollection = Collection
    End Sub

    Public Sub Initialize(host As CustomController_UI_Handler) Implements CustomController_Interface.Initialize
        Hosty = host
    End Sub
End Class
