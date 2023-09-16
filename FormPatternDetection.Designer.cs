namespace Project1Fixed
{
    partial class FormPatternDetection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chartCandlestick = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelDisplayTicker = new System.Windows.Forms.Label();
            this.labelTickerDisplay = new System.Windows.Forms.Label();
            this.comboBoxPattern = new System.Windows.Forms.ComboBox();
            this.labelPattern = new System.Windows.Forms.Label();
            this.labelDisplayingPattern = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCandlestick)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(237, 341);
            this.dataGridView2.TabIndex = 0;
            // 
            // chartCandlestick
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCandlestick.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCandlestick.Legends.Add(legend1);
            this.chartCandlestick.Location = new System.Drawing.Point(273, 57);
            this.chartCandlestick.MinimumSize = new System.Drawing.Size(500, 500);
            this.chartCandlestick.Name = "chartCandlestick";
            this.chartCandlestick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Daily";
            series1.YValuesPerPoint = 4;
            this.chartCandlestick.Series.Add(series1);
            this.chartCandlestick.Size = new System.Drawing.Size(1138, 753);
            this.chartCandlestick.TabIndex = 2;
            this.chartCandlestick.Text = "chart1";
            // 
            // labelDisplayTicker
            // 
            this.labelDisplayTicker.AutoSize = true;
            this.labelDisplayTicker.Location = new System.Drawing.Point(380, 37);
            this.labelDisplayTicker.Name = "labelDisplayTicker";
            this.labelDisplayTicker.Size = new System.Drawing.Size(0, 16);
            this.labelDisplayTicker.TabIndex = 3;
            // 
            // labelTickerDisplay
            // 
            this.labelTickerDisplay.AutoSize = true;
            this.labelTickerDisplay.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTickerDisplay.Location = new System.Drawing.Point(12, 23);
            this.labelTickerDisplay.Name = "labelTickerDisplay";
            this.labelTickerDisplay.Size = new System.Drawing.Size(216, 37);
            this.labelTickerDisplay.TabIndex = 4;
            this.labelTickerDisplay.Text = "TickerSymbol";
            // 
            // comboBoxPattern
            // 
            this.comboBoxPattern.FormattingEnabled = true;
            this.comboBoxPattern.Location = new System.Drawing.Point(12, 475);
            this.comboBoxPattern.Name = "comboBoxPattern";
            this.comboBoxPattern.Size = new System.Drawing.Size(207, 24);
            this.comboBoxPattern.TabIndex = 5;
            this.comboBoxPattern.SelectedIndexChanged += new System.EventHandler(this.comboBoxPattern_SelectedIndexChanged);
            // 
            // labelPattern
            // 
            this.labelPattern.AutoSize = true;
            this.labelPattern.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPattern.Location = new System.Drawing.Point(7, 443);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(77, 24);
            this.labelPattern.TabIndex = 6;
            this.labelPattern.Text = "Pattern:";
            // 
            // labelDisplayingPattern
            // 
            this.labelDisplayingPattern.AutoSize = true;
            this.labelDisplayingPattern.Location = new System.Drawing.Point(13, 567);
            this.labelDisplayingPattern.Name = "labelDisplayingPattern";
            this.labelDisplayingPattern.Size = new System.Drawing.Size(0, 16);
            this.labelDisplayingPattern.TabIndex = 7;
            // 
            // FormPatternDetection
            // 
            this.ClientSize = new System.Drawing.Size(1423, 822);
            this.Controls.Add(this.labelDisplayingPattern);
            this.Controls.Add(this.labelPattern);
            this.Controls.Add(this.comboBoxPattern);
            this.Controls.Add(this.labelTickerDisplay);
            this.Controls.Add(this.labelDisplayTicker);
            this.Controls.Add(this.chartCandlestick);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormPatternDetection";
            this.Text = "Stock Chart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCandlestick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCandlestick;
        private System.Windows.Forms.Label labelDisplayTicker;
        private System.Windows.Forms.Label labelTickerDisplay;
        private System.Windows.Forms.ComboBox comboBoxPattern;
        private System.Windows.Forms.Label labelPattern;
        private System.Windows.Forms.Label labelDisplayingPattern;
    }
}