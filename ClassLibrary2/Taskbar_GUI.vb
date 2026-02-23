Imports System.Windows.Forms

Public Class Taskbar_GUI
    Private Menu_Mode_Looker As String = "StartMenu"

    Private IsInUse As String = ""

    Private Sub Button1_Click()
        MsgBox(IsInUse)
        'If Form_1pad.Menu_ = "0" Then
        'If Form_1pad.StartMenuPanel2.Visible = True Then
        'Form_1pad.StartMenuPanel2.Visible = False
        'ElseIf Form_1pad.StartMenuPanel2.Visible = False Then
        'Contains Search Menu Shit
        'If UI.Search_Menu = True Then
        'Menu_Mode_Looker = "Search"
        'Form_1pad.StartMenuPanel2.Controls.Remove(UI.StartMenuGUI)
        'Form_1pad.StartMenuPanel2.Controls.Remove(Form_1pad.StartMenuControls)
        'UI.SearchMenuGUI.Dock = DockStyle.Fill
        'Form_1pad.StartMenuPanel2.Controls.Add(UI.SearchMenuGUI)
        'ElseIf Form_1pad.StartMenuPanel2.Controls.Contains(UI.SearchMenuGUI) Then
        'Menu_Mode_Looker = "StartMenu"
        'Form_1pad.StartMenuPanel2.Controls.Remove(UI.SearchMenuGUI)
        'Form_1pad.StartMenuPanel2.Controls.Remove(Form_1pad.StartMenuControls)
        'Form_1pad.StartMenuPanel2.Controls.Add(UI.StartMenuGUI)
        'End If
        'Form_1pad.StartMenuPanel.Visible = True
        'Form_1pad.StartMenuPanel2.Visible = True
        'Form_1pad.StartMenuPanel2.BackColor = Form_1pad.TaskbarPanel.BackColor
        'Form_1pad.StartMenuControls.Panel1.Visible = True
        'UI.StartMenuGUI.Label1.Text = Form_1pad.Username
        'End If

        'ElseIf Form_1pad.Menu_ = "1" Then
        'Form30.LoadUI("{B5A2FE71-4025-4025-9824-5D7D57803690}")
        'End If

    End Sub

    Private Sub Taskbar_GUI_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        'Form_1pad.TaskbarPanel_MouseDown(Me, e)
    End Sub

    Private Sub Button1_1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IsInUse = "StartMenu"
        StartMenu_click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'IsInUse = "SearchMenu"
        'UI.Search_Menu = True
        'Button1_Click()
        'UI.Search_Menu = False
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
            ShellCodePart.UI.ShowError("This would have opened TryOS's internal StartMenu_GUI inside a new form")
            'ShellCodePart.Form1.OpenChildForm(New Form30)
        End If

    End Sub
End Class
