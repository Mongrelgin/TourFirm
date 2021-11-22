
namespace KursWork2._0
{
    partial class CountryPeriodTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.russia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.france = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.england = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.india = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.period,
            this.russia,
            this.usa,
            this.japan,
            this.france,
            this.england,
            this.germany,
            this.india});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // period
            // 
            this.period.HeaderText = "Период";
            this.period.MinimumWidth = 6;
            this.period.Name = "period";
            this.period.Width = 110;
            // 
            // russia
            // 
            this.russia.HeaderText = "Россия";
            this.russia.MinimumWidth = 6;
            this.russia.Name = "russia";
            this.russia.Width = 110;
            // 
            // usa
            // 
            this.usa.HeaderText = "США";
            this.usa.MinimumWidth = 6;
            this.usa.Name = "usa";
            this.usa.Width = 110;
            // 
            // japan
            // 
            this.japan.HeaderText = "Япония";
            this.japan.MinimumWidth = 6;
            this.japan.Name = "japan";
            this.japan.Width = 110;
            // 
            // france
            // 
            this.france.HeaderText = "Франция";
            this.france.MinimumWidth = 6;
            this.france.Name = "france";
            this.france.Width = 110;
            // 
            // england
            // 
            this.england.HeaderText = "Англия";
            this.england.MinimumWidth = 6;
            this.england.Name = "england";
            this.england.Width = 110;
            // 
            // germany
            // 
            this.germany.HeaderText = "Германия";
            this.germany.MinimumWidth = 6;
            this.germany.Name = "germany";
            this.germany.Width = 110;
            // 
            // india
            // 
            this.india.HeaderText = "Индия";
            this.india.MinimumWidth = 6;
            this.india.Name = "india";
            this.india.Width = 110;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 284);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Страны по периодам";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn period;
        private System.Windows.Forms.DataGridViewTextBoxColumn russia;
        private System.Windows.Forms.DataGridViewTextBoxColumn usa;
        private System.Windows.Forms.DataGridViewTextBoxColumn japan;
        private System.Windows.Forms.DataGridViewTextBoxColumn france;
        private System.Windows.Forms.DataGridViewTextBoxColumn england;
        private System.Windows.Forms.DataGridViewTextBoxColumn germany;
        private System.Windows.Forms.DataGridViewTextBoxColumn india;
    }
}