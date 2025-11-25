Imports System.Windows.Forms
Imports System.Drawing

Public Class TheOne
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BringItBack()
    End Sub

    Public Panel2 As Panel
    Public TaskbarUserControl As TouchTest.Taskbar_GUI

    Public Sub BringItBack()
        Panel2 = ShellCodePart.Form1.funnything()
        TaskbarUserControl = New TouchTest.Taskbar_GUI
        Panel2.Controls.Add(TaskbarUserControl)
        TaskbarUserControl.Dock = DockStyle.Fill
        TaskbarUserControl.BringToFront()
        TaskbarUserControl.BackColor = Color.Transparent





        'AddHandler TaskbarUserControl.
    End Sub

    Private IsStartMenuOpen As Boolean = False

    Private Sub StartMenu_click(sender As Object, e As EventArgs)
        If IsStartMenuOpen = True Then
            IsStartMenuOpen = False
            Try
                ShellCodePart.Form1.currentForm.Close()
            Catch ex As Exception
            End Try
        Else
            IsStartMenuOpen = True
            ShellCodePart.Form1.OpenChildForm(New Form30)
        End If

    End Sub

    Public Function GetObjectFromPanel(Name As String, Container As Control.ControlCollection, maxInt As Int64, currentInt As Int64) As Int32

        Try
            Dim ff As Control = Container.Item(Convert.ToInt32(currentInt))
            MsgBox(ff.Name)
            If ff.Name = Name Then
                Return currentInt
            End If
        Catch ex As Exception

        End Try


        If currentInt = maxInt Then
            Exit Function
        Else
            GetObjectFromPanel(Name, Container, maxInt, currentInt + 1)
        End If
    End Function

    Public Button1_ As Button
    Public Button2_ As Button

    Public Shared FlowLayoutPanel1 As FlowLayoutPanel

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(My.Application.Info.Version.ToString)
        '  Button1_ = TaskbarUserControl.Controls.Item(0)
        ' AddHandler Button1_.Click, AddressOf StartMenu_click
        Button2_ = TaskbarUserControl.Controls.Item(1)
        AddHandler Button2_.Click, AddressOf StartMenu_click
    End Sub

    Private Sub AddHandlerToAllTesting(parent As Control)
        For Each c As Control In parent.Controls
            If c.Name = "FlowLayoutPanel1" Then
                FlowLayoutPanel1 = CType(c, FlowLayoutPanel)
            End If
            ' AddHandler gg.Click, AddressOf AnyControl_Click
            If c.HasChildren Then AddHandlerToAllTesting(c)
        Next
    End Sub
End Class