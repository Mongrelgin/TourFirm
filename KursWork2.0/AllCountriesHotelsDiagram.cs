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
    public partial class AllCountriesHotelsDiagram : Form
    {
        public AllCountriesHotelsDiagram()
        {
            InitializeComponent();
        }

        public void setChart(int[,] data, string[] countries, int x, int y)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    chart1.Series[i].Points.AddXY(countries[j], data[j, i]);
                }
            }
        }
    }
}
