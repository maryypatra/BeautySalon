using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalonCRM
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {




            cartesianChart1.XAxes = new List<Axis>
            {
                new Axis
                {
                    // Use the labels property to define named labels.
                    Labels = new string[] { "Anne", "Johnny", "Zac", "Rosa" }
                }
            };

            cartesianChart1.Series = new ISeries[]
           {
                new ColumnSeries<double>
    {
        Values = new double[] { 2, 5, 4 }
    }
           };
        }
    }
}
