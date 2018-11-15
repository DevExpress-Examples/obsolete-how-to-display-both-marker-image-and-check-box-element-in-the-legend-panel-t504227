<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MarkerAndCheckbox/Form1.cs) (VB: [Form1.vb](./VB/MarkerAndCheckbox/Form1.vb))
<!-- default file list end -->
# How to display both marker image and check box element in the legend panel


<strong>NOTE.</strong> Starting with v17.1, the chart's legend items can display a marker and check box simultaneously (see the <strong>Legend.MarkerMode</strong> property).<br><br>When the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressXtraChartsLegend_UseCheckBoxestopic.aspx">Legend.UseCheckBoxes</a> feature is enabled, Series markers are not displayed in the Legend panel. It is possible to force displaying both markers and checkbox items by handling the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_CustomDrawSeriestopic">ChartControl.CustomDrawSeries</a> event and assigning a marker image to the e.LegendMarkerImage property.<br>This approach is applicable both to the <strong>ChartControl</strong> and <strong>WebChartControl</strong> (see the <a href="https://documentation.devexpress.com/#AspNet/DevExpressXtraChartsWebWebChartControl_CustomDrawSeriestopic">WebChartControl.CustomDrawSeries</a> event).

<br/>


