Imports System.Web.Optimization

Public Class BundleConfig

    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)

        Dim scriptBundle = New Bundle("~/Scripts/bundle")
        Dim styleBundle = New Bundle("~/Content/bundle")

        ' jQuery
        scriptBundle.Include("~/Scripts/jquery-3.6.0.js")

        ' Bootstrap
        scriptBundle.Include("~/Scripts/bootstrap.js")

        ' Bootstrap
        styleBundle.Include("~/Content/bootstrap.css")

        ' Custom site styles
        styleBundle.Include("~/Content/Site.css")

        bundles.Add(scriptBundle)
        bundles.Add(styleBundle)

        ' BundleTable.EnableOptimizations = True
    End Sub
End Class
