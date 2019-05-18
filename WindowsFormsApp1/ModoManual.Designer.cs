namespace WindowsFormsApp1
{
    partial class Simulador_Casino
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador_Casino));
            this.label2 = new System.Windows.Forms.Label();
            this.LabelProbabilidadDeGanar = new System.Windows.Forms.Label();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelCuota = new System.Windows.Forms.Label();
            this.LabelsaldoActual = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelApuesta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBoxProb = new System.Windows.Forms.TextBox();
            this.TextBoxApu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.TextBoxSaldo = new System.Windows.Forms.TextBox();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btreiniciar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo Actual: ";
            // 
            // LabelProbabilidadDeGanar
            // 
            this.LabelProbabilidadDeGanar.AutoSize = true;
            this.LabelProbabilidadDeGanar.Location = new System.Drawing.Point(65, 135);
            this.LabelProbabilidadDeGanar.Name = "LabelProbabilidadDeGanar";
            this.LabelProbabilidadDeGanar.Size = new System.Drawing.Size(155, 17);
            this.LabelProbabilidadDeGanar.TabIndex = 2;
            this.LabelProbabilidadDeGanar.Text = "Probabilidad de Ganar:";
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(636, 204);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(88, 17);
            this.LabelEstado.TabIndex = 3;
            this.LabelEstado.Text = "Ganó/Perdió";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuota De Apuesta:";
            // 
            // LabelCuota
            // 
            this.LabelCuota.AutoSize = true;
            this.LabelCuota.Location = new System.Drawing.Point(217, 204);
            this.LabelCuota.Name = "LabelCuota";
            this.LabelCuota.Size = new System.Drawing.Size(45, 17);
            this.LabelCuota.TabIndex = 5;
            this.LabelCuota.Text = "Cuota";
            // 
            // LabelsaldoActual
            // 
            this.LabelsaldoActual.AutoSize = true;
            this.LabelsaldoActual.Location = new System.Drawing.Point(471, 204);
            this.LabelsaldoActual.Name = "LabelsaldoActual";
            this.LabelsaldoActual.Size = new System.Drawing.Size(44, 17);
            this.LabelsaldoActual.TabIndex = 6;
            this.LabelsaldoActual.Text = "Saldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "$";
            // 
            // LabelApuesta
            // 
            this.LabelApuesta.AutoSize = true;
            this.LabelApuesta.Location = new System.Drawing.Point(65, 85);
            this.LabelApuesta.Name = "LabelApuesta";
            this.LabelApuesta.Size = new System.Drawing.Size(103, 17);
            this.LabelApuesta.TabIndex = 8;
            this.LabelApuesta.Text = "Apuesta inicial:";
            this.LabelApuesta.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1159, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Apostar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(68, 272);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1166, 401);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "BBBBBB";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TextBoxProb
            // 
            this.TextBoxProb.Location = new System.Drawing.Point(239, 135);
            this.TextBoxProb.Name = "TextBoxProb";
            this.TextBoxProb.Size = new System.Drawing.Size(73, 22);
            this.TextBoxProb.TabIndex = 15;
            this.TextBoxProb.TextChanged += new System.EventHandler(this.TextBoxProb_TextChanged);
            // 
            // TextBoxApu
            // 
            this.TextBoxApu.Location = new System.Drawing.Point(239, 85);
            this.TextBoxApu.Name = "TextBoxApu";
            this.TextBoxApu.Size = new System.Drawing.Size(127, 22);
            this.TextBoxApu.TabIndex = 16;
            this.TextBoxApu.TextChanged += new System.EventHandler(this.TextBoxApu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "%";
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(431, 43);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 25);
            this.LabelError.TabIndex = 18;
            // 
            // TextBoxSaldo
            // 
            this.TextBoxSaldo.Location = new System.Drawing.Point(239, 38);
            this.TextBoxSaldo.Name = "TextBoxSaldo";
            this.TextBoxSaldo.Size = new System.Drawing.Size(127, 22);
            this.TextBoxSaldo.TabIndex = 23;
            this.TextBoxSaldo.TextChanged += new System.EventHandler(this.TextBoxSaldo_TextChanged);
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.AutoSize = true;
            this.LabelSaldo.Location = new System.Drawing.Point(65, 35);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(87, 17);
            this.LabelSaldo.TabIndex = 22;
            this.LabelSaldo.Text = "Saldo inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "$";
            // 
            // btreiniciar
            // 
            this.btreiniciar.Location = new System.Drawing.Point(1159, 66);
            this.btreiniciar.Name = "btreiniciar";
            this.btreiniciar.Size = new System.Drawing.Size(75, 31);
            this.btreiniciar.TabIndex = 60;
            this.btreiniciar.Text = "Reiniciar";
            this.btreiniciar.UseVisualStyleBackColor = true;
            this.btreiniciar.Click += new System.EventHandler(this.btreiniciar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(1159, 29);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 31);
            this.btnMenu.TabIndex = 61;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Simulador_Casino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1275, 713);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btreiniciar);
            this.Controls.Add(this.TextBoxSaldo);
            this.Controls.Add(this.LabelSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxApu);
            this.Controls.Add(this.TextBoxProb);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelApuesta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LabelsaldoActual);
            this.Controls.Add(this.LabelCuota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelEstado);
            this.Controls.Add(this.LabelProbabilidadDeGanar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulador_Casino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Apuestas";
            this.Load += new System.EventHandler(this.Simulador_Casino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelProbabilidadDeGanar;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelCuota;
        private System.Windows.Forms.Label LabelsaldoActual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelApuesta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TextBoxProb;
        private System.Windows.Forms.TextBox TextBoxApu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.TextBox TextBoxSaldo;
        private System.Windows.Forms.Label LabelSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btreiniciar;
        private System.Windows.Forms.Button btnMenu;
    }
}

