Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace MarkerAndCheckbox

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            chart.DataSource = CreateChartData()
            chart.SeriesDataMember = "Month"
            chart.SeriesTemplate.ArgumentDataMember = "Section"
            chart.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Value"})
            chart.SeriesTemplate.View = New StackedBarSeriesView()
        End Sub

        Private Function CreateChartData() As DataTable
            Dim table As DataTable = New DataTable("Table1")
            table.Columns.Add("Month", GetType(String))
            table.Columns.Add("Section", GetType(String))
            table.Columns.Add("Value", GetType(Integer))
            table.Rows.Add(New Object() {"Jan", "Section1", 10})
            table.Rows.Add(New Object() {"Jan", "Section2", 20})
            table.Rows.Add(New Object() {"Feb", "Section1", 20})
            table.Rows.Add(New Object() {"Feb", "Section2", 30})
            table.Rows.Add(New Object() {"March", "Section1", 15})
            table.Rows.Add(New Object() {"March", "Section2", 25})
            Return table
        End Function

        Private Sub chart_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            Dim lmi As Bitmap = New Bitmap(33, 15)
            Dim g As Graphics = Graphics.FromImage(lmi)
            g.FillRectangle(New SolidBrush(e.SeriesDrawOptions.Color), New Rectangle(0, 0, 17, 15))
            g.DrawRectangle(New Pen(e.SeriesDrawOptions.Color), New Rectangle(18, 0, 14, 14))
            If e.Series.CheckedInLegend Then
                g.DrawLines(New Pen(e.SeriesDrawOptions.Color, 2), New Point() {New Point(21, 6), New Point(25, 10), New Point(29, 3)})
            End If

            e.LegendMarkerImage = lmi
        End Sub
    End Class
End Namespace
