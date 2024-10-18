Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports System.Net.Http.Formatting
Imports System.Net.Http.Headers
Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        config.EnableCors()
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
        'Media Type Mapping Based on Query String
        config.Formatters.JsonFormatter.MediaTypeMappings.Add(
                                       New QueryStringMapping("frmt", "json",
                                       New MediaTypeHeaderValue("application/json")))
        config.Formatters.XmlFormatter.MediaTypeMappings.Add(
                                        New QueryStringMapping("frmt", "xml",
                                        New MediaTypeHeaderValue("application/xml")))
    End Sub
End Module
