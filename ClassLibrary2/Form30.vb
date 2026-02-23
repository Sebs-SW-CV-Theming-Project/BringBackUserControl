Imports System.Windows.Forms
Imports System.Drawing

Public Class Form30
    Public StartMenuGUI As TouchTest.StartMenu_GUI
    Public temptimer As New Timer

    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'StartMenuGUI = New TouchTest.StartMenu_GUI
        'Me.Controls.Add(StartMenuGUI)
        'StartMenuGUI.Dock = DockStyle.Fill

        'temptimer.Interval = 500
        'temptimer.Enabled = True
        'AddHandler temptimer.Tick, AddressOf temptimer_Tick
    End Sub

    Private Sub temptimer_Tick(sender As Object, e As EventArgs)
        temptimer.Stop()

        'Dim ff As New Form
        'ff.Show()
        'ff.Size = New Drawing.Size(600, 600)
        'ff.Controls.Add(jj)
        'jj.Size = New Drawing.Size(200, 200)
        'jj.Dock = DockStyle.Fill

        'Dim ff2 As New Form
        'ff2.Show()
        'ff2.Controls.Add(kk)
        'kk.Size = New Drawing.Size(200, 200)
        'kk.Dock = DockStyle.Fill


        AddHandlerToAll(Me)

        FlowLayoutPanel1 = TheOne.FlowLayoutPanel1

        StartMenuGUI.Controls.Add(Panel3)
        Panel3.Location = New Drawing.Point(0, 0)
        Panel3.Size = New Drawing.Size(500, 500)
        Panel3.BackColor = Color.DarkBlue

        Panel3.Controls.Add(FlowLayoutPanel1)
        FlowLayoutPanel1.BackColor = Color.Blue
        FlowLayoutPanel1.Dock = DockStyle.Fill


        Panel3.BringToFront()
        FlowLayoutPanel1.BringToFront()
        Timer1.Start()

        AddHandlerToAllTesting(ShellCodePart.Form1)
    End Sub

    Public FlowLayoutPanel1 As FlowLayoutPanel
    Public Panel3 As New Panel

    Private Sub AddHandlerToAll(parent As Control)
        For Each c As Control In parent.Controls
            If c.Name = "Panel1" Then
                c.Visible = False
            ElseIf c.Name = "Button2" Then
                c.Visible = False
            ElseIf c.Name = "Button3" Then
                c.Visible = False
            ElseIf c.Name = "Button4" Then
                c.Visible = False
            ElseIf c.Name = "Button5" Then
                c.Visible = False
            ElseIf c.Name = "Button6" Then
                c.Visible = False
            ElseIf c.Name = "Button7" Then
                c.Visible = False
            ElseIf c.Name = "Button8" Then
                c.Visible = False
            ElseIf c.Name = "Button1" Then
                c.Text = "Log out"
                AddHandler c.Click, Sub(sender As Object, e As EventArgs)
                                        If Environment.CommandLine.Contains("/UseNewLoader") = True Then
                                            ShellCodePart.UI.LogOut()
                                        Else
                                            ShellCodePart.Form1.LogOut()
                                        End If

                                    End Sub



            ElseIf c.Name = "Button12" Then
                AddHandler c.Click, Sub(sender As Object, e As EventArgs)
                                        ShellCodePart.UI.RunCommands("Console>end")
                                    End Sub
            ElseIf c.Name = "Button13" Then
                AddHandler c.Click, Sub(sender As Object, e As EventArgs)
                                        Try
                                            ShellCodePart.Form1.currentForm.Close()
                                        Catch ex As Exception
                                        End Try
                                        ShellCodePart.Form1.Close()
                                        Application.Restart()
                                    End Sub
            ElseIf c.Name = "Label1" Then
                c.Text = ShellCodePart.Form1.User.Username
            End If
            'AddHandler gg.Click, AddressOf AnyControl_Click
            If c.HasChildren Then AddHandlerToAll(c)
        Next
    End Sub

    Private kk As New PropertyGrid
    Private jj As New FlowLayoutPanel

    Private Sub AddHandlerToAllTesting(parent As Control)
        For Each c As Control In parent.Controls
            Dim gg As New Button
            gg.Text = c.Name
            gg.Tag = c
            jj.Controls.Add(gg)
            AddHandler gg.Click, AddressOf AnyControl_Click
            If c.HasChildren Then AddHandlerToAll(c)
        Next
    End Sub

    Private Sub AnyControl_Click(sender As Object, e As EventArgs)
        Dim c As Control = CType(sender.Tag, Control)

        kk.SelectedObject = c
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ShellCodePart.Hosty.OpenFramework_RestoreButtonOrder(True, FlowLayoutPanel1)
    End Sub
End Class