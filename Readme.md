<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574434/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T504227)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MarkerAndCheckbox/Form1.cs) (VB: [Form1.vb](./VB/MarkerAndCheckbox/Form1.vb))
<!-- default file list end -->
# How to display both marker image and check box element in the legend panel


<strong>NOTE.</strong> Starting with v17.1, the chart's legend items can display a marker and check box simultaneously (see the <strong>Legend.MarkerMode</strong> property).<br><br>When the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpressXtraChartsLegend_UseCheckBoxestopic.aspx">Legend.UseCheckBoxes</a> feature is enabled, Series markers are not displayed in the Legend panel. It is possible to force displaying both markers and checkbox items by handling the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_CustomDrawSeriestopic">ChartControl.CustomDrawSeries</a> event and assigning a marker image to the e.LegendMarkerImage property.<br>This approach is applicable both to the <strong>ChartControl</strong> and <strong>WebChartControl</strong> (see the <a href="https://documentation.devexpress.com/#AspNet/DevExpressXtraChartsWebWebChartControl_CustomDrawSeriestopic">WebChartControl.CustomDrawSeries</a> event).

<br/>


