using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModoAutomatico : Form
    {
        public ModoAutomatico()
        {
            InitializeComponent();
        }

        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            float va, pg, saldo;
            Random rand = new Random();
            chart1.Legends.Clear();

            if (float.TryParse(tbSaldo.Text, out saldo)) // Verifica que el saldo ingresado sea correcto
            {
                tbSaldo.Enabled = false; //No permite que se ingrese un saldo diferente
                LabelsaldoActual.Text = Convert.ToString(saldo);
                //Verificar condiciones de la apuesta
                if (cbRisk.Checked == true)
                {
                    //Apuesta arriesgada
                    pg = rand.Next(1, 30);
                }
                else
                {
                    //Apuesta Conservadora
                    pg = rand.Next(31, 100);
                }
                if (cbDer.Checked == true)
                {
                    //Estrategia Derrochadora
                    int min = (int)(saldo / 2);
                    int max = (int)(saldo * 0.9);
                    va = rand.Next(min, max);
                }
                else
                {
                    //Estrategia Conservadora
                    int min = (int)(saldo / 10);
                    int max = (int)(saldo / 5);
                    va = rand.Next(min, max);
                }

                if (float.Parse(LabelsaldoActual.Text) > 0) //Solo puede apostar si tiene saldo
                {

                    if (int.TryParse(tbApu.Text, out int loop))
                    {
                        for (int i = 0; i < loop; i++)
                        {

                            Apuesta(va, pg);
                            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Intento";
                            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Saldo";
                            chart1.Series["Series1"].Points.AddXY(x, float.Parse(LabelsaldoActual.Text));
                            x++;

                            if (float.Parse(LabelsaldoActual.Text) <= 0) //Si el saldo llega a 0 deja de apostar
                            {
                                LabelMsg.Text = "Perdiste todo tu saldo :(";
                                button1.Enabled = false;
                                break;
                            }
                        }
                    }

                }
                else
                {
                    LabelError.Text = "Número de apuestas no es válido";
                }

            }
            else
            {
                LabelError.Text = "Saldo Ingresado no es válido";
            }
        }

        private void Apuesta(float va, float pg)
        {
            Random rand = new Random();
            int chance = rand.Next(0, 100);
            float ca = 1 / (pg / 100);
            float vg, sac;
            sac = float.Parse(LabelsaldoActual.Text);

            if (chance <= pg)
            {
                //Gana
                //LabelEstado.Text = "Gana";
                vg = va * ca;
                sac = sac - va + vg;
                LabelsaldoActual.Text = Convert.ToString(sac);
                // This Is For Debugging: LabelError.Text = "Random: " + Convert.ToString(chance) + " ca: " + Convert.ToString(ca) + " va: " + Convert.ToString(va) + " pg: " + Convert.ToString(pg) + " vg: " + Convert.ToString(vg);

            }
            else
            {
                //Pierde
                //LabelEstado.Text = "Pierde";
                sac = sac - va;
                LabelsaldoActual.Text = Convert.ToString(sac);
                //This Is For Debugging: LabelError.Text = "Random: " + Convert.ToString(chance) + " va: " + Convert.ToString(va);

            }
        }





        //Configuración de CheckBoxes

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDer.Checked == true)
            {
                cbEcon.Checked = false;
            }
        }

        private void cbRisk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRisk.Checked == true)
            {
                cbCons.Checked = false;
            }
        }

        private void cbCons_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCons.Checked == true)
            {
                cbRisk.Checked = false;
            }
        }

        private void cbEcon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEcon.Checked == true)
            {
                cbDer.Checked = false;
            }
        }

        private void btreiniciar_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            tbSaldo.Enabled = true;
            tbSaldo.Text = "";
            tbApu.Text = "";
            LabelError.Text = "";
            x = 1;
            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Legends.Clear();
        }

        //private void btnMenu_Click(object sender, EventArgs e)
        //{
        //    Menu obj = new Menu();
        //    obj.Show();
        //    this.Hide();
        //}

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }
    }
}
