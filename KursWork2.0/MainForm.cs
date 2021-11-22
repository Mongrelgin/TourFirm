using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KursWork2._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Поток для работы с данными
            Stream stream;
            //Если после вызова диалогового окна нажат OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Если открытый файл не пустой
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    //StreamReader для чтения данных из файла, который принимает параметром конструктора наш поток
                    StreamReader streamReader = new StreamReader(stream);
                    //Массив для записи строки из файла
                    string[] str;
                    //Переменная содержащая количество слов в str
                    int num;
                    try
                    {
                        //Массив принимает в себя все строки разделяя их символом переноса коретки
                        string[] str1 = streamReader.ReadToEnd().Split('\n');
                        //Запись в num кол-ва строк
                        num = str1.Count() - 1;
                        //Устанаваливаем в dataGrid кол-во строк - 1 (т.к. в наших файлах последняя строка пустая)
                        dataGridView1.RowCount = num + 1;
                        //Перебираем все строки
                        for (int i = 0; i < num; i++)
                        {
                            //Записываем в str строку разделяя каждое слово по пробелу
                            str = str1[i].Split(' ');
                            try
                            {
                                //Запись в каждый столбец данных из str
                                dataGridView1.Rows[i].Cells[0].Value = str[0];
                                dataGridView1.Rows[i].Cells[1].Value = country.Items[int.Parse(str[1])];
                                dataGridView1.Rows[i].Cells[2].Value = period.Items[int.Parse(str[2])];
                                dataGridView1.Rows[i].Cells[3].Value = year.Items[int.Parse(str[3])];
                                dataGridView1.Rows[i].Cells[4].Value = duration.Items[int.Parse(str[4])];
                                dataGridView1.Rows[i].Cells[5].Value = hotel.Items[int.Parse(str[5])];
                                dataGridView1.Rows[i].Cells[6].Value = str[6];
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //Закрытие потока и Ридера                        
                        stream.Close();
                        streamReader.Close();                        
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Поток для работы с данными
            Stream stream;
            //Если после вызова диалогового окна нажат OK
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Если открытый файл не пустой
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {
                    //StreamWriter для записи данных в файл, который принимает параметром конструктора наш поток
                    StreamWriter streamWriter = new StreamWriter(stream);
                    try
                    {
                        //Перебираем каждую строку dataGrid
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            //Запись в файл данных (некоторые данные сначала вызывают методы для преобразования)
                            streamWriter.Write(dataGridView1.Rows[i].Cells[0].Value.ToString() + " ");
                            streamWriter.Write(returnCountryComboBoxNumber(dataGridView1.Rows[i].Cells[1].Value.ToString()) + " ");
                            streamWriter.Write(returnPeriodComboBoxNumber(dataGridView1.Rows[i].Cells[2].Value.ToString()) + " ");
                            streamWriter.Write(returnYearComboBoxNumber(dataGridView1.Rows[i].Cells[3].Value.ToString()) + " ");
                            streamWriter.Write(returnDurationComboBoxNumber(dataGridView1.Rows[i].Cells[4].Value.ToString()) + " ");
                            streamWriter.Write(returnHotelComboBoxNumber(dataGridView1.Rows[i].Cells[5].Value.ToString()) + " ");
                            streamWriter.Write(dataGridView1.Rows[i].Cells[6].Value.ToString() + " ");
                            streamWriter.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //Закрытие потока и Врайтера
                        streamWriter.Close();
                        stream.Close();
                    }                    
                }
            }
        }
        
        private string returnCountryComboBoxNumber(string text)
        {
            switch (text)
            {
                case "Россия":
                    return "0";
                case "США":
                    return "1";
                case "Япония":
                    return "2";
                case "Франция":
                    return "3";
                case "Англия":
                    return "4";
                case "Германия":
                    return "5";
                case "Индия":
                    return "6";
                default:
                    return "0";
            }
        }

        private string returnPeriodComboBoxNumber(string text)
        {
            switch (text)
            {
                case "25.12-15.01":
                    return "0";
                case "16.01-31.03":
                    return "1";
                case "01.04-31.05":
                    return "2";
                case "01.06-15.09":
                    return "3";
                case "16.09-24.12":
                    return "4";
                default:
                    return "0";
            }
        }

        private string returnDurationComboBoxNumber(string text)
        {
            switch (text)
            {
                case "7 дней":
                    return "0";
                case "10 дней":
                    return "1";
                case "14 дней":
                    return "2";
                default:
                    return "0";
            }
        }

        private string returnHotelComboBoxNumber(string text)
        {
            switch (text)
            {
                case "2*":
                    return "0";
                case "3*":
                    return "1";
                case "4*":
                    return "2";
                case "5*":
                    return "3";
                default:
                    return "0";
            }
        }

        private string returnYearComboBoxNumber(string text)
        {
            switch (text)
            {
                case "2016":
                    return "0";
                case "2017":
                    return "1";
                case "2018":
                    return "2";
                case "2019":
                    return "3";
                case "2020":
                    return "4";
                default:
                    return "0";
            }
        }

        private void buttonBestYear_Click(object sender, EventArgs e)
        {
            int yearCell = 3;
            int soldQuantityCell = 6;
            int year16 = 0;
            int year17 = 0;
            int year18 = 0;
            int year19 = 0;
            int year20 = 0;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string text = dataGridView1.Rows[i].Cells[yearCell].Value.ToString();
                int value = int.Parse(dataGridView1.Rows[i].Cells[soldQuantityCell].Value.ToString());

                switch (text)
                {
                    case "2016":
                        year16 += value;
                        break;
                    case "2017":
                        year17 += value;
                        break;
                    case "2018":
                        year18 += value;
                        break;
                    case "2019":
                        year19 += value;
                        break;
                    case "2020":
                        year20 += value;
                        break;
                    default:
                        break;
                }
            }

            int[] numbers = new int[] { year16, year17, year18, year19, year20 };
            int maxNumber = numbers.Max();

            if (maxNumber == year16)
                textBoxBestYear.Text = "2016";
            else if (maxNumber == year17)
                textBoxBestYear.Text = "2017";
            else if (maxNumber == year18)
                textBoxBestYear.Text = "2018";
            else if (maxNumber == year19)
                textBoxBestYear.Text = "2019";
            else
                textBoxBestYear.Text = "2020";
        }

        private void buttonCountrySellOnPeriod_Click(object sender, EventArgs e)
        {
            CountryPeriodTable form2 = new CountryPeriodTable();
            DataGridView dataGrid = new DataGridView();
            int i = 0;
            int j = 0;
            int rows = 5;
            int columns = 7;
            int[,] data = new int[columns, rows];
            int tickets;
            string country;
            string period;

            dataGrid.RowCount = rows;
            dataGrid.ColumnCount = columns + 1;
            dataGrid.Rows[0].Cells[0].Value = "25.12 - 15.01";
            dataGrid.Rows[1].Cells[0].Value = "16.01 - 31.03";
            dataGrid.Rows[2].Cells[0].Value = "01.04 - 31.05";
            dataGrid.Rows[3].Cells[0].Value = "01.06 - 15.09";
            dataGrid.Rows[4].Cells[0].Value = "16.09 - 24.12";

            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                country = dataGridView1.Rows[x].Cells[1].Value.ToString();
                tickets = int.Parse(dataGridView1.Rows[x].Cells[6].Value.ToString());
                period = dataGridView1.Rows[x].Cells[2].Value.ToString();

                switch (country)
                {
                    case "Россия":
                        i = 0;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "США":
                        i = 1;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "Япония":
                        i = 2;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "Франция":
                        i = 3;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "Англия":
                        i = 4;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "Германия":
                        i = 5;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "Индия":
                        i = 6;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    default:
                        break;
                }
                data[i, j] += tickets;
            }

            for (int x = 0; x < rows; x++)
                for (int y = 0; y < columns; y++)
                    dataGrid.Rows[x].Cells[y + 1].Value = data[y, x];

            form2.setDataGrid(dataGrid);
            form2.Show();
        }

        private void buttonSortCountry_Click(object sender, EventArgs e)
        {
            CountryTicketsTable form3 = new CountryTicketsTable();
            DataGridView dataGrid = new DataGridView();
            string[] countries = new string[7];
            int[] tickets = new int[7];
            string country;
            int ticket;
            int gridRows = 7;
            int gridColumns = 2;

            dataGrid.RowCount = gridRows;
            dataGrid.ColumnCount = gridColumns;

            countries[0] = "Россия";
            countries[1] = "США";
            countries[2] = "Япония";
            countries[3] = "Франция";
            countries[4] = "Англия";
            countries[5] = "Германия";
            countries[6] = "Индия";

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                country = dataGridView1.Rows[i].Cells[1].Value.ToString();
                ticket = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());

                switch (country)
                {
                    case "Россия":
                        tickets[0] += ticket;
                        break;
                    case "США":
                        tickets[1] += ticket;
                        break;
                    case "Япония":
                        tickets[2] += ticket;
                        break;
                    case "Франция":
                        tickets[3] += ticket;
                        break;
                    case "Англия":
                        tickets[4] += ticket;
                        break;
                    case "Германия":
                        tickets[5] += ticket;
                        break;
                    case "Индия":
                        tickets[6] += ticket;
                        break;
                    default:
                        MessageBox.Show("Error!");
                        break;
                }
            }

            for (int i = 0; i < countries.Length; i++)
            {
                if ((i + 1) < countries.Length)
                {
                    if (tickets[i] < tickets[i + 1])
                    {
                        int a = tickets[i];
                        string text = countries[i];
                        tickets[i] = tickets[i + 1];
                        countries[i] = countries[i + 1];
                        tickets[i + 1] = a;
                        countries[i + 1] = text;
                        i = -1;
                    }
                }
            }

            for (int i = 0; i < gridRows; i++)
            {
                dataGrid.Rows[i].Cells[0].Value = countries[i];
                dataGrid.Rows[i].Cells[1].Value = tickets[i];
            }

            form3.setDatGrid(dataGrid);
            form3.Show();
        }

        private void buttonPeriodCharts_Click(object sender, EventArgs e)
        {
            SellPeriodsGraphics form4 = new SellPeriodsGraphics();
            int years = 5;
            int periods = 5;
            int[,] data = new int[years, periods];
            int tickets;
            string year;
            string period;
            int i = 0;
            int j = 0;


            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                year = dataGridView1.Rows[x].Cells[3].Value.ToString();
                tickets = int.Parse(dataGridView1.Rows[x].Cells[6].Value.ToString());
                period = dataGridView1.Rows[x].Cells[2].Value.ToString();

                switch (year)
                {
                    case "2016":
                        i = 0;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "2017":
                        i = 1;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "2018":
                        i = 2;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "2019":
                        i = 3;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    case "2020":
                        i = 4;
                        if (period == "25.12-15.01") j = 0;
                        if (period == "16.01-31.03") j = 1;
                        if (period == "01.04-31.05") j = 2;
                        if (period == "01.06-15.09") j = 3;
                        if (period == "16.09-24.12") j = 4;
                        break;
                    default:
                        break;
                }
                data[i, j] += tickets;
            }
            form4.setChart(data);
            form4.Show();
        }

        private void buttonDiagramFromCoutry_Click(object sender, EventArgs e)
        {
            CountryDiagram form5 = new CountryDiagram();
            int countryIndex = comboBoxCountries.SelectedIndex;
            int periods = 5;
            int[] data = new int[periods];
            string country;
            string period;
            int tickets;

            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                country = dataGridView1.Rows[x].Cells[1].Value.ToString();
                tickets = int.Parse(dataGridView1.Rows[x].Cells[6].Value.ToString());
                period = dataGridView1.Rows[x].Cells[2].Value.ToString();

                if (countryIndex == int.Parse(returnCountryComboBoxNumber(country)))
                {
                    switch (period)
                    {
                        case "25.12-15.01":
                            data[0] += tickets;
                            break;
                        case "16.01-31.03":
                            data[1] += tickets;
                            break;
                        case "01.04-31.05":
                            data[2] += tickets;
                            break;
                        case "01.06-15.09":
                            data[3] += tickets;
                            break;
                        case "16.09-24.12":
                            data[4] += tickets;
                            break;
                        default:
                            break;
                    }
                }
            }

            form5.setChart(data, comboBoxCountries.Text);
            form5.Show();
        }

        private void buttonAllHotelsDiagram_Click(object sender, EventArgs e)
        {
            AllCountriesHotelsDiagram form6 = new AllCountriesHotelsDiagram();
            int countries = 7;
            int hotels = 4;
            int[,] data = new int[countries, hotels];
            string[] allcountries = new string[countries];
            string country;
            string hotel;
            int tickets;
            int i = 0;
            int j = 0;
            allcountries[0] = "Россия";
            allcountries[1] = "США";
            allcountries[2] = "Япония";
            allcountries[3] = "Франция";
            allcountries[4] = "Англия";
            allcountries[5] = "Германия";
            allcountries[6] = "Индия";

            for (int x = 0; x < dataGridView1.RowCount - 1; x++)
            {
                country = dataGridView1.Rows[x].Cells[1].Value.ToString();
                tickets = int.Parse(dataGridView1.Rows[x].Cells[6].Value.ToString());
                hotel = dataGridView1.Rows[x].Cells[5].Value.ToString();

                switch (country)
                {
                    case "Россия":
                        i = 0;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    case "США":
                        i = 1;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    case "Япония":
                        i = 2;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    case "Франция":
                        i = 3;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    case "Англия":
                        i = 4;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    case "Германия":
                        i = 5;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    case "Индия":
                        i = 6;
                        if (hotel == "2*") j = 0;
                        if (hotel == "3*") j = 1;
                        if (hotel == "4*") j = 2;
                        if (hotel == "5*") j = 3;
                        break;
                    default:
                        break;
                }
                data[i, j] += tickets;
            }

            form6.setChart(data, allcountries, countries, hotels);
            form6.Show();
        }
    }
}
