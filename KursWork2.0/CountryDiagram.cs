using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursWork2._0
{
    public partial class CountryDiagram : Form
    {
        public CountryDiagram()
        {
            InitializeComponent();
        }

        public void setChart(int[] data, string country)
        {
            chart1.Series[0].Points.AddXY("25.12-15.01", data[0]);
            chart1.Series[0].Points.AddXY("16.01-31.03", data[1]);
            chart1.Series[0].Points.AddXY("01.04-31.05", data[2]);
            chart1.Series[0].Points.AddXY("01.06-15.09", data[3]);
            chart1.Series[0].Points.AddXY("16.09-24.12", data[4]);
            this.Text = country;
        }
    }
}
