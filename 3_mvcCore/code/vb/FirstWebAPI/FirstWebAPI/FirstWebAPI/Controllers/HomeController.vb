Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return RedirectToAction("", "api/Product")
        End Function
    End Class
End Namespace