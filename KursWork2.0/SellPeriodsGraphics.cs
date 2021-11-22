using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KursWork2._0
{
    public partial class SellPeriodsGraphics : Form
    {
        public SellPeriodsGraphics()
        {
            InitializeComponent();
        }

        public void setChart(int[,] data)
        {
            int b = 5;
            int x;
            int y;
            for (int i = 0; i < b; i++)
            {
                x = 0;
                for (int j = 0; j < b; j++)
                {
                    y = data[i, j];
                    chart1.Series[i].Points.AddXY(x + 2016, y);
                    x++;
                }
            }
        }
    }
}
