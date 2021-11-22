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
    public partial class CountryTicketsTable : Form
    {
        public CountryTicketsTable()
        {
            InitializeComponent();
        }
        public void setDatGrid(DataGridView dataGrid)
        {

            dataGridView1.RowCount = dataGrid.RowCount;
            dataGridView1.ColumnCount = dataGrid.ColumnCount;
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = dataGrid.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
