Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        'GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        DevExtremeBundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
End Class