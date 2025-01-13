Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports PointOfSale.ClassConnections
Public Class CancelQuotation


    Dim dAdapt, da As Odbc.OdbcDataAdapter
    Dim dSet As DataSet
    Dim ds As New DataSet
    Dim a As Integer = 0
    Dim dBind As New BindingSource
    Dim classconn As New ClassConnections
    Dim classPos As New ClassPOS
    Dim mysqlConn As String = classconn.GetServerVariables()
    Dim ConnSqlStr As String = classconn.GetSqlConnStr()
    Public Shared formCode As String
    Dim change As Double = SalesRefunds.txt_balance.Text
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private UpdateCode As Integer

    Private Sub CancelQuotation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not (My.Computer.Keyboard.ShiftKeyDown) And e.KeyCode = Keys.F4 Then
            Me.exitBtn.PerformClick()

        ElseIf Not (My.Computer.Keyboard.ShiftKeyDown) And e.KeyCode = Keys.Enter Then
            btn_ok.PerformClick()

        End If
    End Sub

    Private Sub exitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitBtn.Click
        Quotation.timer_quotation.Enabled = True
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Call classPos.cancelSale()
        Quotation.timer_quotation.Enabled = True
        Me.Close()
    End Sub

    Private Sub panelheader_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelheader.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub panelheader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelheader.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub panelheader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelheader.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False


        End If
    End Sub

    Private Sub CancelQuotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call classPos.log_data("Started cancel quotation")
    End Sub

    Private Sub CancelQuotation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Call classPos.log_data("Ended cancel quotation")
    End Sub
End Class