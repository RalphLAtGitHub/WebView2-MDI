Public Class Form1

    Private ReadOnly m_WebViewForm As WebViewForm

    Public Sub New()

        InitializeComponent()

        Me.IsMdiContainer = True
        Me.StartPosition = FormStartPosition.CenterScreen

        m_WebViewForm = New WebViewForm With {.MdiParent = Me, .Name = "DEMO"}  'Should generating a form in reserve be a coherent solution?  
        Debug.WriteLine("First MDI-child " + Me.MdiChildren.First.Name + " is of type " + Me.MdiChildren.First.GetType.ToString)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        m_WebViewForm.Show()

    End Sub

    'Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)

    '    MyBase.OnFormClosing(e)
    '    m_WebViewForm.Show()     'is a workaround

    'End Sub

End Class
