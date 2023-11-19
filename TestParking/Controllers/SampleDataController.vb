Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports TestParking.Models
Imports DevExtreme.AspNet.Data
Imports DevExtreme.AspNet.Mvc

Namespace Controllers
	Public Class SampleDataController
		Inherits ApiController

		<HttpGet> _
		Public Function [Get](ByVal loadOptions As DataSourceLoadOptions) As HttpResponseMessage
			Return Request.CreateResponse(DataSourceLoader.Load(SampleData.Orders, loadOptions))
		End Function

	End Class
End Namespace