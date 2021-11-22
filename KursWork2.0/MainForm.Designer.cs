
namespace KursWork2._0
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBestYear = new System.Windows.Forms.TextBox();
            this.buttonBestYear = new System.Windows.Forms.Button();
            this.buttonCountrySellOnPeriod = new System.Windows.Forms.Button();
            this.buttonSortCountry = new System.Windows.Forms.Button();
            this.buttonPeriodCharts = new System.Windows.Forms.Button();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDiagramFromCoutry = new System.Windows.Forms.Button();
            this.buttonAllHotelsDiagram = new System.Windows.Forms.Button();
            this.pathNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.period = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hotel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.soldQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathNumber,
            this.country,
            this.period,
            this.year,
            this.duration,
            this.hotel,
            this.soldQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(999, 31);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 29);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1148, 31);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(996, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "BestSelling year";
            // 
            // textBoxBestYear
            // 
            this.textBoxBestYear.Location = new System.Drawing.Point(1130, 90);
            this.textBoxBestYear.Name = "textBoxBestYear";
            this.textBoxBestYear.Size = new System.Drawing.Size(112, 22);
            this.textBoxBestYear.TabIndex = 4;
            // 
            // buttonBestYear
            // 
            this.buttonBestYear.Location = new System.Drawing.Point(999, 149);
            this.buttonBestYear.Name = "buttonBestYear";
            this.buttonBestYear.Size = new System.Drawing.Size(243, 29);
            this.buttonBestYear.TabIndex = 5;
            this.buttonBestYear.Text = "Calculate";
            this.buttonBestYear.UseVisualStyleBackColor = true;
            this.buttonBestYear.Click += new System.EventHandler(this.buttonBestYear_Click);
            // 
            // buttonCountrySellOnPeriod
            // 
            this.buttonCountrySellOnPeriod.Location = new System.Drawing.Point(999, 201);
            this.buttonCountrySellOnPeriod.Name = "buttonCountrySellOnPeriod";
            this.buttonCountrySellOnPeriod.Size = new System.Drawing.Size(243, 29);
            this.buttonCountrySellOnPeriod.TabIndex = 6;
            this.buttonCountrySellOnPeriod.Text = "Country sell on period";
            this.buttonCountrySellOnPeriod.UseVisualStyleBackColor = true;
            this.buttonCountrySellOnPeriod.Click += new System.EventHandler(this.buttonCountrySellOnPeriod_Click);
            // 
            // buttonSortCountry
            // 
            this.buttonSortCountry.Location = new System.Drawing.Point(999, 252);
            this.buttonSortCountry.Name = "buttonSortCountry";
            this.buttonSortCountry.Size = new System.Drawing.Size(243, 29);
            this.buttonSortCountry.TabIndex = 7;
            this.buttonSortCountry.Text = "Country sorted";
            this.buttonSortCountry.UseVisualStyleBackColor = true;
            this.buttonSortCountry.Click += new System.EventHandler(this.buttonSortCountry_Click);
            // 
            // buttonPeriodCharts
            // 
            this.buttonPeriodCharts.Location = new System.Drawing.Point(999, 301);
            this.buttonPeriodCharts.Name = "buttonPeriodCharts";
            this.buttonPeriodCharts.Size = new System.Drawing.Size(243, 29);
            this.buttonPeriodCharts.TabIndex = 8;
            this.buttonPeriodCharts.Text = "Charts in period";
            this.buttonPeriodCharts.UseVisualStyleBackColor = true;
            this.buttonPeriodCharts.Click += new System.EventHandler(this.buttonPeriodCharts_Click);
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Япония",
            "Франция",
            "Англия",
            "Германия",
            "Индия"});
            this.comboBoxCountries.Location = new System.Drawing.Point(1121, 350);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCountries.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(996, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Country";
            // 
            // buttonDiagramFromCoutry
            // 
            this.buttonDiagramFromCoutry.Location = new System.Drawing.Point(999, 391);
            this.buttonDiagramFromCoutry.Name = "buttonDiagramFromCoutry";
            this.buttonDiagramFromCoutry.Size = new System.Drawing.Size(243, 29);
            this.buttonDiagramFromCoutry.TabIndex = 11;
            this.buttonDiagramFromCoutry.Text = "Diagram on country";
            this.buttonDiagramFromCoutry.UseVisualStyleBackColor = true;
            this.buttonDiagramFromCoutry.Click += new System.EventHandler(this.buttonDiagramFromCoutry_Click);
            // 
            // buttonAllHotelsDiagram
            // 
            this.buttonAllHotelsDiagram.Location = new System.Drawing.Point(999, 439);
            this.buttonAllHotelsDiagram.Name = "buttonAllHotelsDiagram";
            this.buttonAllHotelsDiagram.Size = new System.Drawing.Size(243, 29);
            this.buttonAllHotelsDiagram.TabIndex = 12;
            this.buttonAllHotelsDiagram.Text = "All hotels diagrams";
            this.buttonAllHotelsDiagram.UseVisualStyleBackColor = true;
            this.buttonAllHotelsDiagram.Click += new System.EventHandler(this.buttonAllHotelsDiagram_Click);
            // 
            // pathNumber
            // 
            this.pathNumber.HeaderText = "№ Маршрута";
            this.pathNumber.MinimumWidth = 6;
            this.pathNumber.Name = "pathNumber";
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Япония",
            "Франция",
            "Англия",
            "Германия",
            "Индия"});
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // period
            // 
            this.period.HeaderText = "Период";
            this.period.Items.AddRange(new object[] {
            "25.12-15.01",
            "16.01-31.03",
            "01.04-31.05",
            "01.06-15.09",
            "16.09-24.12"});
            this.period.MinimumWidth = 6;
            this.period.Name = "period";
            this.period.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.period.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // year
            // 
            this.year.HeaderText = "Год";
            this.year.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.year.Width = 70;
            // 
            // duration
            // 
            this.duration.HeaderText = "Длительность";
            this.duration.Items.AddRange(new object[] {
            "7 дней",
            "10 дней",
            "14 дней"});
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.duration.Width = 110;
            // 
            // hotel
            // 
            this.hotel.HeaderText = "Отель";
            this.hotel.Items.AddRange(new object[] {
            "2*",
            "3*",
            "4*",
            "5*"});
            this.hotel.MinimumWidth = 6;
            this.hotel.Name = "hotel";
            this.hotel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hotel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hotel.Width = 70;
            // 
            // soldQuantity
            // 
            this.soldQuantity.HeaderText = "Кол-во путевок";
            this.soldQuantity.MinimumWidth = 6;
            this.soldQuantity.Name = "soldQuantity";
            this.soldQuantity.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 498);
            this.Controls.Add(this.buttonAllHotelsDiagram);
            this.Controls.Add(this.buttonDiagramFromCoutry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.buttonPeriodCharts);
            this.Controls.Add(this.buttonSortCountry);
            this.Controls.Add(this.buttonCountrySellOnPeriod);
            this.Controls.Add(this.buttonBestYear);
            this.Controls.Add(this.textBoxBestYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Курсовая";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBestYear;
        private System.Windows.Forms.Button buttonBestYear;
        private System.Windows.Forms.Button buttonCountrySellOnPeriod;
        private System.Windows.Forms.Button buttonSortCountry;
        private System.Windows.Forms.Button buttonPeriodCharts;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDiagramFromCoutry;
        private System.Windows.Forms.Button buttonAllHotelsDiagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn country;
        private System.Windows.Forms.DataGridViewComboBoxColumn period;
        private System.Windows.Forms.DataGridViewComboBoxColumn year;
        private System.Windows.Forms.DataGridViewComboBoxColumn duration;
        private System.Windows.Forms.DataGridViewComboBoxColumn hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQuantity;
    }
}

