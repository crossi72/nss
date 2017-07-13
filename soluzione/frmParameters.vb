Public Class frmParameters

    Private Sub btnSetPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPath.Click
        Me.OpenFileDialog1.ShowDialog()

        If Me.OpenFileDialog1.FileName <> "" Then
            Me.txtParKernelPath.Text = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub frmParameters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TAParameters.Fill(Me.Parameters._parameters)

        Me.txtParKernelPath.Text = Me.Parameters._parameters.Rows(0).Item("parKernelPath")

        'set URL for Wolfram Mathematica Player download page
        Me.LinkLabel1.Links.Remove(Me.LinkLabel1.Links(0))
        Me.LinkLabel1.Links.Add(0, Me.LinkLabel1.Text.Length, "http://www.wolfram.com/products/player/download.cgi")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim sInfo As New ProcessStartInfo(e.Link.LinkData.ToString())
        Process.Start(sInfo)
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim sqlQuery As String

        'set new value in db
        sqlQuery = "UPDATE parameters" & ControlChars.CrLf
        sqlQuery &= "SET parKernelPath ='" & Me.OpenFileDialog1.FileName & "'" & ControlChars.CrLf

        clsUtility.ExecuteSQL(sqlQuery, Me.TAParameters.Connection)

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class