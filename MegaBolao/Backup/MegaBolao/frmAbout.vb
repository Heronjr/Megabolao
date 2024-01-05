Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga do form
        '02/02/10
        '=============
        Me.Text = Application.ProductName & " V-" & Application.ProductVersion & " Build " & My.Application.Info.Version.Build

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Click no quadro
        '02/02/10
        '===============
        Me.Close()

    End Sub

End Class