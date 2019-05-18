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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulador_Casino obj = new Simulador_Casino();
            obj.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModoAutomatico obj = new ModoAutomatico();
            obj.Show();
            this.Hide();
        }
    }
}
