﻿
Partial Class ErrorTest
    Inherits System.Web.UI.Page

Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  Dim a(10) As Integer
  Dim i As Integer
  Try
    For i = 1 To 11
      a(i) = i
    Next
  Catch ex As Exception
    messageLabel.Text = "Exception!<br />" & ex.Message
  End Try

End Sub
End Class
