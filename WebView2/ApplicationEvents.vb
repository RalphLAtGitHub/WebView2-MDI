Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            Debug.WriteLine(vbCrLf + e.Exception.Message + vbCrLf + e.Exception.Source + vbCrLf + e.Exception.StackTrace)

        End Sub

    End Class

End Namespace
