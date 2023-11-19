@Imports TestParking.Models

@Code
    ViewBag.Title = "Index"
End Code

<h2>Home</h2>

@(Html.DevExtreme().DataGrid(Of SampleOrder)() _
            .ShowBorders(True) _
            .DataSource(Function(d) d.WebApi().Controller("SampleData").Key("OrderID")) _
            .Columns(Sub(columns)
                         columns.AddFor(Function(m) m.OrderID)
                         columns.AddFor(Function(m) m.OrderDate)
                         columns.AddFor(Function(m) m.CustomerName)
                         columns.AddFor(Function(m) m.ShipCountry)
                         columns.AddFor(Function(m) m.ShipCity)
                     End Sub) _
            .Paging(Sub(p) p.PageSize(10)) _
            .FilterRow(Sub(f) f.Visible(True)) _
            .HeaderFilter(Sub(f) f.Visible(True)) _
            .GroupPanel(Sub(p) p.Visible(True)) _
            .Grouping(Sub(g) g.AutoExpandAll(False)) _
            .RemoteOperations(True) _
            .Summary(Sub(s)
                         s.TotalItems(Sub(totalItems) totalItems.AddFor(Function(m) m.ShipCity).SummaryType(SummaryType.Count))
                         s.GroupItems(Sub(groupItems) groupItems.Add().SummaryType(SummaryType.Count))
                     End Sub)
)