namespace PocasiWinForm
{
    partial class PocasiWinForm1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.chChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTemp = new System.Windows.Forms.Label();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.lbErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(12, 7);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(170, 26);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Aktuální teplota";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(636, 12);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(152, 21);
            this.cbSelect.TabIndex = 1;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.CbSelect_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(12, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 26);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "-----";
            // 
            // chChart
            // 
            this.chChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chChart.Legends.Add(legend1);
            this.chChart.Location = new System.Drawing.Point(17, 100);
            this.chChart.Name = "chChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "-";
            this.chChart.Series.Add(series1);
            this.chChart.Size = new System.Drawing.Size(771, 315);
            this.chChart.TabIndex = 3;
            this.chChart.Text = "chart1";
            // 
            // lbTemp
            // 
            this.lbTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTemp.Location = new System.Drawing.Point(690, 59);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(57, 26);
            this.lbTemp.TabIndex = 4;
            this.lbTemp.Text = "-- °C";
            // 
            // rbC
            // 
            this.rbC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbC.AutoSize = true;
            this.rbC.Checked = true;
            this.rbC.Location = new System.Drawing.Point(711, 421);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(36, 17);
            this.rbC.TabIndex = 5;
            this.rbC.TabStop = true;
            this.rbC.Text = "°C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(753, 421);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(35, 17);
            this.rbF.TabIndex = 6;
            this.rbF.Text = "°F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // lbErr
            // 
            this.lbErr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbErr.AutoSize = true;
            this.lbErr.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbErr.ForeColor = System.Drawing.Color.Red;
            this.lbErr.Location = new System.Drawing.Point(459, 14);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(171, 19);
            this.lbErr.TabIndex = 7;
            this.lbErr.Text = "Problém s připojením";
            this.lbErr.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbErr);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.chChart);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "PočasíWinForm";
            ((System.ComponentModel.ISupportInitialize)(this.chChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chChart;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.Label lbErr;
    }
}

