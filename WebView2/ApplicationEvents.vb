Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

           If e.Exception.Source = "Microsoft.Web.WebView2.WinForms" Then

                Debug.WriteLine(vbCrLf + e.Exception.Message + vbCrLf + e.Exception.Source + vbCrLf + e.Exception.StackTrace)
                e.ExitApplication = False

            End If

        End Sub

    End Class

End Namespace
