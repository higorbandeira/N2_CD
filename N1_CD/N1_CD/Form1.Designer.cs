namespace N1_CD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGeraGrafico = new System.Windows.Forms.Button();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtQTD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblF0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(155, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "f0";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(560, 297);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btnGeraGrafico
            // 
            this.btnGeraGrafico.Location = new System.Drawing.Point(12, 224);
            this.btnGeraGrafico.Name = "btnGeraGrafico";
            this.btnGeraGrafico.Size = new System.Drawing.Size(137, 33);
            this.btnGeraGrafico.TabIndex = 1;
            this.btnGeraGrafico.Text = "Gerar Gráfico";
            this.btnGeraGrafico.UseVisualStyleBackColor = true;
            this.btnGeraGrafico.Click += new System.EventHandler(this.btnGeraGrafico_Click);
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(12, 96);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(137, 20);
            this.txtRA.TabIndex = 2;
            // 
            // txtQTD
            // 
            this.txtQTD.Location = new System.Drawing.Point(12, 148);
            this.txtQTD.Name = "txtQTD";
            this.txtQTD.Size = new System.Drawing.Size(137, 20);
            this.txtQTD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtd. Termos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "F0";
            // 
            // lblF0
            // 
            this.lblF0.AutoSize = true;
            this.lblF0.Location = new System.Drawing.Point(744, 12);
            this.lblF0.Name = "lblF0";
            this.lblF0.Size = new System.Drawing.Size(13, 13);
            this.lblF0.TabIndex = 7;
            this.lblF0.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.lblF0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQTD);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.btnGeraGrafico);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnGeraGrafico;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtQTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblF0;
    }
}

