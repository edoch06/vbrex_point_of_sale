Imports System
Imports System.data
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Public Class BlockedGroupSelection



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
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private UpdateCode As Integer

  
End Class