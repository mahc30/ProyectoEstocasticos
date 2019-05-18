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

namespace WindowsFormsApp1
{
    public partial class Simulador_Casino : Form
    {
        private float saldo, apuesta;
        private int prob;
        private short intento = 0;

        public Simulador_Casino()
        {
            InitializeComponent();
        }

        private void TextBoxProb_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxProb.Text, out prob))
            {
                if (prob < 100 && prob > 0)
                {
                    LabelCuota.Text = CalcularCuotaApuesta(prob);
                    LabelError.Text = "";
                }
                else
                {
                    LabelError.Text = "La probabilidad debe estar entre 0 y 100";
                }
            }


        }

        private void TextBoxSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxApu_TextChanged(object sender, EventArgs e)
        {

        }

        public string CalcularCuotaApuesta(float pg) //Obtener la cuota de apuesta
        {
            float ca;
            ca = 1 / (pg / 100);
            string s = Convert.ToString(ca);
            return s;

        }

        private float Apuesta()
        {
            float va, sac, saa, vg, ca, pg;
            int random;
            Random rand = new Random();
            random = rand.Next(0, 100);
            chart1.Legends.Clear();

            if (float.TryParse(TextBoxSaldo.Text, out saldo) && float.TryParse(TextBoxApu.Text, out va) && float.TryParse(TextBoxProb.Text, out pg)) //Obtener el Datos
            {
                if (intento == 0)
                {
                    chart1.Series["Series1"].Points.AddXY(0, saldo);
                    LabelsaldoActual.Text = Convert.ToString(saldo);
                    TextBoxSaldo.Enabled = false;
                    LabelApuesta.Text = "Apostar:";
                    intento++;
                }

                sac = float.Parse(LabelsaldoActual.Text);
                saa = sac;

                if (sac >= va)
                {
                    if (random <= pg)
                    {
                        LabelEstado.Text = "Gana";

                        ca = 1 / (pg / 100);
                        vg = va * ca;
                        sac = saa - va + vg;
                        LabelsaldoActual.Text = Convert.ToString(sac);
                        return sac;
                        // This Is For Debugging: LabelError.Text = "Random: " + Convert.ToString(random) + " ca: " + Convert.ToString(ca) + " va: " + Convert.ToString(va) + " pg: " + Convert.ToString(pg) + " vg: " + Convert.ToString(vg);
                    }
                    else
                    {
                        //This Is For Debugging: LabelError.Text = "Random: " + Convert.ToString(random);
                        LabelEstado.Text = "Pierde";
                        sac = float.Parse(LabelsaldoActual.Text);
                        LabelsaldoActual.Text = Convert.ToString(sac - va);
                        if(sac <= 0)
                        {
                            button1.Enabled = false;
                        }

                        return sac;
                    }
                }
                else
                {
                    LabelError.Text = "Tu saldo actual no es suficiente :(";
                    return -1;
                }
            }
            else
            {
                LabelError.Text = "Alguna Cantidad Ingresada no es Válida";
                return -1;
            }
        }

        int x = 1;

        private void btreiniciar_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            TextBoxSaldo.Enabled = true;
            TextBoxSaldo.Text = "";
            TextBoxApu.Text = "";
            TextBoxProb.Text = "";
            LabelError.Text = "";
            x = 1;
            intento = 0;
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Legends.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (float.TryParse(TextBoxSaldo.Text, out saldo) && float.TryParse(TextBoxApu.Text, out float b) && float.TryParse(TextBoxProb.Text, out float d)) //Obtener el Datos
            {
                button1.Enabled = true;
                Apuesta();
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Intento";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Saldo";
                chart1.Series["Series1"].Points.AddXY(x, float.Parse(LabelsaldoActual.Text));
                x++;
            }
            
               
         
        }


        //chart1.DataSource = dt;

        //chart1.Series["Series1"].XValueMember = "X_Value";
        //chart1.Series["Series1"].YValueMembers = "Y_Value";
        //chart1.Series["Series1"].ChartType = SeriesChartType.Line;
        //chart1.ChartAreas[0].AxisY.LabelStyle.Format = "";

        //DataTable dt = new DataTable();
        //dt.Columns.Add("X_Value", typeof(double));
        //dt.Columns.Add("Y_Value", typeof(double));

        //string line;
        //line = "3,5";


        ////while ((line = sr.ReadLine()) != null)
        ////{
        //string[] strarr = line.Split(',');
        //dt.Rows.Add(strarr[0], strarr[1]);
        //dt.Rows.Add("4", "3");
        //dt.Rows.Add("5", "5");
        //dt.Rows.Add("6", "4");
        ////}


        //// if (sr != null) sr.Close();
    }


}



















