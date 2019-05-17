﻿namespace WindowsFormsApp1
{
    partial class ModoAutomatico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModoAutomatico));
            this.LabelError = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelsaldoActual = new System.Windows.Forms.Label();
            this.LabelMsg = new System.Windows.Forms.Label();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.LabelProbabilidadDeGanar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRisk = new System.Windows.Forms.CheckBox();
            this.cbCons = new System.Windows.Forms.CheckBox();
            this.cbDer = new System.Windows.Forms.CheckBox();
            this.cbEcon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(378, 54);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 25);
            this.LabelError.TabIndex = 37;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 255);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(886, 401);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "BBBBBB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Apostar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelsaldoActual
            // 
            this.LabelsaldoActual.AutoSize = true;
            this.LabelsaldoActual.Location = new System.Drawing.Point(420, 210);
            this.LabelsaldoActual.Name = "LabelsaldoActual";
            this.LabelsaldoActual.Size = new System.Drawing.Size(44, 17);
            this.LabelsaldoActual.TabIndex = 29;
            this.LabelsaldoActual.Text = "Saldo";
            // 
            // LabelMsg
            // 
            this.LabelMsg.AutoSize = true;
            this.LabelMsg.Location = new System.Drawing.Point(99, 200);
            this.LabelMsg.Name = "LabelMsg";
            this.LabelMsg.Size = new System.Drawing.Size(0, 17);
            this.LabelMsg.TabIndex = 28;
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(445, 197);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(0, 17);
            this.LabelEstado.TabIndex = 26;
            // 
            // LabelProbabilidadDeGanar
            // 
            this.LabelProbabilidadDeGanar.AutoSize = true;
            this.LabelProbabilidadDeGanar.Location = new System.Drawing.Point(22, 102);
            this.LabelProbabilidadDeGanar.Name = "LabelProbabilidadDeGanar";
            this.LabelProbabilidadDeGanar.Size = new System.Drawing.Size(155, 17);
            this.LabelProbabilidadDeGanar.TabIndex = 25;
            this.LabelProbabilidadDeGanar.Text = "Probabilidad de Ganar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Saldo Actual: ";
            // 
            // tbApu
            // 
            this.tbApu.Location = new System.Drawing.Point(175, 58);
            this.tbApu.Name = "tbApu";
            this.tbApu.Size = new System.Drawing.Size(106, 22);
            this.tbApu.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Número de Apuestas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Valor Apostado:";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(173, 26);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(106, 22);
            this.tbSaldo.TabIndex = 52;
            this.tbSaldo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Saldo Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "$";
            // 
            // cbRisk
            // 
            this.cbRisk.AutoSize = true;
            this.cbRisk.Location = new System.Drawing.Point(183, 102);
            this.cbRisk.Name = "cbRisk";
            this.cbRisk.Size = new System.Drawing.Size(99, 21);
            this.cbRisk.TabIndex = 54;
            this.cbRisk.Text = "Arriesgado";
            this.cbRisk.UseVisualStyleBackColor = true;
            this.cbRisk.CheckedChanged += new System.EventHandler(this.cbRisk_CheckedChanged);
            // 
            // cbCons
            // 
            this.cbCons.AutoSize = true;
            this.cbCons.Location = new System.Drawing.Point(293, 102);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(111, 21);
            this.cbCons.TabIndex = 55;
            this.cbCons.Text = "Conservador";
            this.cbCons.UseVisualStyleBackColor = true;
            this.cbCons.CheckedChanged += new System.EventHandler(this.cbCons_CheckedChanged);
            // 
            // cbDer
            // 
            this.cbDer.AutoSize = true;
            this.cbDer.Location = new System.Drawing.Point(175, 147);
            this.cbDer.Name = "cbDer";
            this.cbDer.Size = new System.Drawing.Size(110, 21);
            this.cbDer.TabIndex = 56;
            this.cbDer.Text = "Derrochador";
            this.cbDer.UseVisualStyleBackColor = true;
            this.cbDer.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbEcon
            // 
            this.cbEcon.AutoSize = true;
            this.cbEcon.Location = new System.Drawing.Point(305, 148);
            this.cbEcon.Name = "cbEcon";
            this.cbEcon.Size = new System.Drawing.Size(120, 21);
            this.cbEcon.TabIndex = 57;
            this.cbEcon.Text = "Economizador";
            this.cbEcon.UseVisualStyleBackColor = true;
            this.cbEcon.CheckedChanged += new System.EventHandler(this.cbEcon_CheckedChanged);
            // 
            // ModoAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 684);
            this.Controls.Add(this.cbEcon);
            this.Controls.Add(this.cbDer);
            this.Controls.Add(this.cbCons);
            this.Controls.Add(this.cbRisk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbApu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelsaldoActual);
            this.Controls.Add(this.LabelMsg);
            this.Controls.Add(this.LabelEstado);
            this.Controls.Add(this.LabelProbabilidadDeGanar);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModoAutomatico";
            this.Text = "ModoAutomatico";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelsaldoActual;
        private System.Windows.Forms.Label LabelMsg;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.Label LabelProbabilidadDeGanar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbApu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbRisk;
        private System.Windows.Forms.CheckBox cbCons;
        private System.Windows.Forms.CheckBox cbDer;
        private System.Windows.Forms.CheckBox cbEcon;
    }
}