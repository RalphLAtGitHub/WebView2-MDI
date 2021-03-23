Public Class Form1

    Private ReadOnly m_WebViewForm As WebViewForm

    Public Sub New()

        InitializeComponent()

        Me.IsMdiContainer = True
        Me.StartPosition = FormStartPosition.CenterScreen

        m_WebViewForm = New WebViewForm With {.MdiParent = Me}  'Should generating a form in reserve be a coherent solution?       

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        m_WebViewForm.Show()

    End Sub

End Class