using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace MarkerAndCheckbox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            chart.DataSource = CreateChartData();

            chart.SeriesDataMember = "Month";
            chart.SeriesTemplate.ArgumentDataMember = "Section";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            chart.SeriesTemplate.View = new StackedBarSeriesView();

        }

        private DataTable CreateChartData() {

            DataTable table = new DataTable("Table1");

            table.Columns.Add("Month", typeof(String));
            table.Columns.Add("Section", typeof(String));
            table.Columns.Add("Value", typeof(Int32));

            table.Rows.Add(new object[] { "Jan", "Section1", 10 });
            table.Rows.Add(new object[] { "Jan", "Section2", 20 });
            table.Rows.Add(new object[] { "Feb", "Section1", 20 });
            table.Rows.Add(new object[] { "Feb", "Section2", 30 });
            table.Rows.Add(new object[] { "March", "Section1", 15 });
            table.Rows.Add(new object[] { "March", "Section2", 25 });

            return table;
        }

        private void chart_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            Bitmap lmi = new Bitmap(33, 15);
            Graphics g = Graphics.FromImage(lmi);
            g.FillRectangle(new SolidBrush(e.SeriesDrawOptions.Color), new Rectangle(0, 0, 17, 15));
            g.DrawRectangle(new Pen(e.SeriesDrawOptions.Color), new Rectangle(18, 0, 14, 14));
            if (e.Series.CheckedInLegend) {
                g.DrawLines(new Pen(e.SeriesDrawOptions.Color, 2), new Point[] { new Point(21, 6), new Point(25, 10), new Point(29, 3) });
            }
            e.LegendMarkerImage = lmi;
        }
    }
}
